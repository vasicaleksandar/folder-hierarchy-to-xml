namespace Folder_hierarchy_to_XML
{
    partial class formFolderHierarchy
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
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.txtChosenDirectory = new System.Windows.Forms.TextBox();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.tvDirectoryHierarchy = new System.Windows.Forms.TreeView();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 12);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(117, 23);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // txtChosenDirectory
            // 
            this.txtChosenDirectory.Location = new System.Drawing.Point(135, 15);
            this.txtChosenDirectory.Name = "txtChosenDirectory";
            this.txtChosenDirectory.ReadOnly = true;
            this.txtChosenDirectory.Size = new System.Drawing.Size(419, 20);
            this.txtChosenDirectory.TabIndex = 1;
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Enabled = false;
            this.btnSaveXml.Location = new System.Drawing.Point(12, 62);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveXml.TabIndex = 2;
            this.btnSaveXml.Text = "Save XML";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // tvDirectoryHierarchy
            // 
            this.tvDirectoryHierarchy.Location = new System.Drawing.Point(13, 192);
            this.tvDirectoryHierarchy.Name = "tvDirectoryHierarchy";
            this.tvDirectoryHierarchy.Size = new System.Drawing.Size(260, 307);
            this.tvDirectoryHierarchy.TabIndex = 3;
            this.tvDirectoryHierarchy.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDirectoryHierarchy_NodeMouseClick);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(289, 192);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(265, 307);
            this.txtDetails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Details about selected folder/file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folder hierarchy";
            // 
            // formFolderHierarchy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.tvDirectoryHierarchy);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.txtChosenDirectory);
            this.Controls.Add(this.btnChooseFolder);
            this.Name = "formFolderHierarchy";
            this.Text = "Folder hierarchy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox txtChosenDirectory;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.TreeView tvDirectoryHierarchy;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

