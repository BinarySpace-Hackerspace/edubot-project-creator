namespace EduBot_Project_Creator
{
  partial class mainFrm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblEduBotSoftwarePath = new System.Windows.Forms.Label();
      this.txtEduBotPath = new System.Windows.Forms.TextBox();
      this.btnBrowseEduBotSoftware = new System.Windows.Forms.Button();
      this.txtProjectName = new System.Windows.Forms.TextBox();
      this.lblProjectName = new System.Windows.Forms.Label();
      this.btnBrowseProjectFolder = new System.Windows.Forms.Button();
      this.txtProjectPath = new System.Windows.Forms.TextBox();
      this.lblProjectPath = new System.Windows.Forms.Label();
      this.btnCreateProject = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblEduBotSoftwarePath
      // 
      this.lblEduBotSoftwarePath.AutoSize = true;
      this.lblEduBotSoftwarePath.Location = new System.Drawing.Point(12, 86);
      this.lblEduBotSoftwarePath.Name = "lblEduBotSoftwarePath";
      this.lblEduBotSoftwarePath.Size = new System.Drawing.Size(115, 13);
      this.lblEduBotSoftwarePath.TabIndex = 0;
      this.lblEduBotSoftwarePath.Text = "EduBot Software Path:";
      // 
      // txtEduBotPath
      // 
      this.txtEduBotPath.Location = new System.Drawing.Point(133, 83);
      this.txtEduBotPath.Name = "txtEduBotPath";
      this.txtEduBotPath.Size = new System.Drawing.Size(536, 20);
      this.txtEduBotPath.TabIndex = 3;
      // 
      // btnBrowseEduBotSoftware
      // 
      this.btnBrowseEduBotSoftware.Location = new System.Drawing.Point(675, 81);
      this.btnBrowseEduBotSoftware.Name = "btnBrowseEduBotSoftware";
      this.btnBrowseEduBotSoftware.Size = new System.Drawing.Size(75, 23);
      this.btnBrowseEduBotSoftware.TabIndex = 4;
      this.btnBrowseEduBotSoftware.Text = "...";
      this.btnBrowseEduBotSoftware.UseVisualStyleBackColor = true;
      this.btnBrowseEduBotSoftware.Click += new System.EventHandler(this.btnBrowseEduBotSoftware_Click);
      // 
      // txtProjectName
      // 
      this.txtProjectName.Location = new System.Drawing.Point(133, 12);
      this.txtProjectName.Name = "txtProjectName";
      this.txtProjectName.Size = new System.Drawing.Size(536, 20);
      this.txtProjectName.TabIndex = 0;
      // 
      // lblProjectName
      // 
      this.lblProjectName.AutoSize = true;
      this.lblProjectName.Location = new System.Drawing.Point(12, 15);
      this.lblProjectName.Name = "lblProjectName";
      this.lblProjectName.Size = new System.Drawing.Size(74, 13);
      this.lblProjectName.TabIndex = 3;
      this.lblProjectName.Text = "Project Name:";
      // 
      // btnBrowseProjectFolder
      // 
      this.btnBrowseProjectFolder.Location = new System.Drawing.Point(675, 36);
      this.btnBrowseProjectFolder.Name = "btnBrowseProjectFolder";
      this.btnBrowseProjectFolder.Size = new System.Drawing.Size(75, 23);
      this.btnBrowseProjectFolder.TabIndex = 2;
      this.btnBrowseProjectFolder.Text = "...";
      this.btnBrowseProjectFolder.UseVisualStyleBackColor = true;
      this.btnBrowseProjectFolder.Click += new System.EventHandler(this.btnBrowseProjectFolder_Click);
      // 
      // txtProjectPath
      // 
      this.txtProjectPath.Location = new System.Drawing.Point(133, 38);
      this.txtProjectPath.Name = "txtProjectPath";
      this.txtProjectPath.Size = new System.Drawing.Size(536, 20);
      this.txtProjectPath.TabIndex = 1;
      // 
      // lblProjectPath
      // 
      this.lblProjectPath.AutoSize = true;
      this.lblProjectPath.Location = new System.Drawing.Point(12, 41);
      this.lblProjectPath.Name = "lblProjectPath";
      this.lblProjectPath.Size = new System.Drawing.Size(68, 13);
      this.lblProjectPath.TabIndex = 5;
      this.lblProjectPath.Text = "Project Path:";
      // 
      // btnCreateProject
      // 
      this.btnCreateProject.Location = new System.Drawing.Point(561, 135);
      this.btnCreateProject.Name = "btnCreateProject";
      this.btnCreateProject.Size = new System.Drawing.Size(189, 23);
      this.btnCreateProject.TabIndex = 5;
      this.btnCreateProject.Text = "Create Project";
      this.btnCreateProject.UseVisualStyleBackColor = true;
      this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
      // 
      // mainFrm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 177);
      this.Controls.Add(this.btnCreateProject);
      this.Controls.Add(this.btnBrowseProjectFolder);
      this.Controls.Add(this.txtProjectPath);
      this.Controls.Add(this.lblProjectPath);
      this.Controls.Add(this.txtProjectName);
      this.Controls.Add(this.lblProjectName);
      this.Controls.Add(this.btnBrowseEduBotSoftware);
      this.Controls.Add(this.txtEduBotPath);
      this.Controls.Add(this.lblEduBotSoftwarePath);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "mainFrm";
      this.Text = "EduBot Project Creator";
      this.Load += new System.EventHandler(this.mainFrm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEduBotSoftwarePath;
    private System.Windows.Forms.TextBox txtEduBotPath;
    private System.Windows.Forms.Button btnBrowseEduBotSoftware;
    private System.Windows.Forms.TextBox txtProjectName;
    private System.Windows.Forms.Label lblProjectName;
    private System.Windows.Forms.Button btnBrowseProjectFolder;
    private System.Windows.Forms.TextBox txtProjectPath;
    private System.Windows.Forms.Label lblProjectPath;
    private System.Windows.Forms.Button btnCreateProject;
  }
}

