using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace EduBot_Project_Creator
{
  public partial class mainFrm : Form
  {


    public mainFrm()
    {
      InitializeComponent();
    }


    private void btnBrowseProjectFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog projectFolderBrowseDialog = new FolderBrowserDialog();

      projectFolderBrowseDialog.ShowNewFolderButton = true;

      if ( projectFolderBrowseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
      {
        txtProjectPath.Text = projectFolderBrowseDialog.SelectedPath;
      }
    }

    private void btnBrowseEduBotSoftware_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog edubotFolderBrowseDialog = new FolderBrowserDialog();

      if ( edubotFolderBrowseDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
      {
        if ( confirmEdubotFolder(edubotFolderBrowseDialog.SelectedPath, false ))
          txtEduBotPath.Text = edubotFolderBrowseDialog.SelectedPath;
      }
    }

    private bool confirmEdubotFolder(string SelectedPath, bool silent)
    {
      // does it exist?
      if ( !Directory.Exists( SelectedPath ))
      {
        if ( !silent) MessageBox.Show( SelectedPath + " does not exist!");
        return false;
      }

      // check for the version filename
      if (!File.Exists(SelectedPath + "\\version.txt"))
      {
        if ( !silent ) MessageBox.Show( SelectedPath + "\\version.txt file not found, Are you sure this is the right folder?");
        return false;
      }

      // check for edubot base folder
      if (!Directory.Exists(SelectedPath + "\\edubotbase"))
      {
        if (!silent) MessageBox.Show(SelectedPath + "\\edubotbase does not exist! Are you sure this is the right folder?");
        return false;
      }

      // check for makefile template
      if (!File.Exists(SelectedPath + "\\edubotbase\\Templates\\MakeFile.template"))
      {
        if (!silent) MessageBox.Show("MakeFile template missing!");
        return false;
      }

      // check for batch file template
      if (!File.Exists(SelectedPath + "\\edubotbase\\Templates\\compilerprompt.template"))
      {
        if (!silent) MessageBox.Show("Compiler Prompt template missing!");
        return false;
      }

      // todo: more checks

      return true;
    }

    private void mainFrm_Load(object sender, EventArgs e)
    {
      // check default
      // todo: check main drive letter
      if (confirmEdubotFolder("c:\\edubot", true))
        txtEduBotPath.Text = "c:\\edubot";
    }

    bool IsValidFilename(string testName)
    {
      Regex containsABadCharacter = new Regex("["
            + Regex.Escape(new string(System.IO.Path.GetInvalidPathChars())) + "]");
      if (containsABadCharacter.IsMatch(testName)) { return false; };

      // todo: other checks for UNC, drive-path format, etc

      return true;
    }

    private void btnCreateProject_Click(object sender, EventArgs e)
    {
      // did we get all the data?

      string projectName = Regex.Replace(txtProjectName.Text.Trim(), @"\s+", "");


      if ( txtProjectName.Text.Length == 0 || !IsValidFilename(projectName))
      {
        MessageBox.Show("You need to specify a valid Project Name (" + projectName + ")");
        return;
      }

      if ( txtProjectPath.Text.Length == 0 || !Directory.Exists(txtProjectPath.Text) )
      {
        MessageBox.Show("You need to specify a valid Project Folder");
        return;
      }

      if (txtEduBotPath.Text.Length == 0 || !confirmEdubotFolder(txtEduBotPath.Text, true))
      {
        MessageBox.Show("You need to specify a valid Project Folder");
        return;
      }

      createProject(projectName, txtProjectPath.Text.Trim(), txtEduBotPath.Text.Trim());

    }

    private void createProject( string projectName, string projectPath, string eduBotPath)
    {
      // todo: validate projectName
      string projectDirectory = projectPath + "\\" + projectName;

      string codeTemplateFile = eduBotPath + "\\edubotbase\\Templates\\app.template";
      string compilerPromptTemplateFile = eduBotPath + "\\edubotbase\\Templates\\compilerprompt.template";
      string makeFileTemplateFile = eduBotPath + "\\edubotbase\\Templates\\MakeFile.template";

      try
      {
        // create project folder
        Directory.CreateDirectory(projectDirectory);

        // create code main
        File.Copy(codeTemplateFile, projectDirectory + "\\" + projectName + ".c" );

        // create makefile 

        using (var writer = new StreamWriter(projectDirectory + "\\MakeFile"))
        using (var reader = new StreamReader(makeFileTemplateFile))
        {
          writer.WriteLine("######################################");
          writer.WriteLine("# Makefile Template for EduBot" );
          writer.WriteLine("######################################");
          writer.WriteLine("");
          writer.WriteLine("TARGET = " + projectName);
          writer.WriteLine("EDUBOT_DIR = " + eduBotPath.Replace('\\', '/'));
          writer.WriteLine("CUSTOMFILES = " + projectName + ".c");
          writer.WriteLine("");

          while (!reader.EndOfStream)
            writer.WriteLine(reader.ReadLine());
        }


        // create batch file
        using (var writer = new StreamWriter(projectDirectory + "\\CompilerPrompt.bat"))
        using (var reader = new StreamReader(compilerPromptTemplateFile))
        {
          writer.WriteLine("path " + eduBotPath + "\\arm\\bin;" + eduBotPath + "\\gnu;" + eduBotPath + "\\edubot\\arm\\arm-none-eabi\\bin;");
          writer.WriteLine("");

          while (!reader.EndOfStream)
            writer.WriteLine(reader.ReadLine());
        }

        MessageBox.Show("Project Created Succesfully");
        Process.Start(projectDirectory);

      }
      catch( Exception Ex )
      {
        MessageBox.Show("Error while creating project: " + Ex.Message);
      }

    }

  }
}
