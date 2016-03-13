namespace FolderProcessor
{
    partial class FolderViewer
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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnFruiteIt = new System.Windows.Forms.Button();
            this.txtFolderLocation = new System.Windows.Forms.TextBox();
            this.lblFolderSelection = new System.Windows.Forms.Label();
            this.dlgOpenFolder = new System.Windows.Forms.OpenFileDialog();
            this.btnResetFolderProcessor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(481, 24);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(60, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // btnFruiteIt
            // 
            this.btnFruiteIt.Location = new System.Drawing.Point(453, 90);
            this.btnFruiteIt.Name = "btnFruiteIt";
            this.btnFruiteIt.Size = new System.Drawing.Size(88, 33);
            this.btnFruiteIt.TabIndex = 1;
            this.btnFruiteIt.Text = "Fruit It";
            this.btnFruiteIt.UseVisualStyleBackColor = true;
            this.btnFruiteIt.Click += new System.EventHandler(this.FruitItButton_Click);
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Location = new System.Drawing.Point(172, 26);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(303, 20);
            this.txtFolderLocation.TabIndex = 2;
            // 
            // lblFolderSelection
            // 
            this.lblFolderSelection.AutoSize = true;
            this.lblFolderSelection.Location = new System.Drawing.Point(12, 29);
            this.lblFolderSelection.Name = "lblFolderSelection";
            this.lblFolderSelection.Size = new System.Drawing.Size(154, 13);
            this.lblFolderSelection.TabIndex = 3;
            this.lblFolderSelection.Text = "Provide Master Folder Location";
            // 
            // dlgOpenFolder
            // 
            this.dlgOpenFolder.FileName = "openFileDialog1";
            // 
            // btnResetFolderProcessor
            // 
            this.btnResetFolderProcessor.Location = new System.Drawing.Point(15, 90);
            this.btnResetFolderProcessor.Name = "btnResetFolderProcessor";
            this.btnResetFolderProcessor.Size = new System.Drawing.Size(101, 33);
            this.btnResetFolderProcessor.TabIndex = 4;
            this.btnResetFolderProcessor.Text = "Reset";
            this.btnResetFolderProcessor.UseVisualStyleBackColor = true;
            this.btnResetFolderProcessor.Click += new System.EventHandler(this.ResetFolderProcessorButton_Click);
            // 
            // FolderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 138);
            this.Controls.Add(this.btnResetFolderProcessor);
            this.Controls.Add(this.lblFolderSelection);
            this.Controls.Add(this.txtFolderLocation);
            this.Controls.Add(this.btnFruiteIt);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "FolderViewer";
            this.Text = "Folder Fruty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnFruiteIt;
        private System.Windows.Forms.TextBox txtFolderLocation;
        private System.Windows.Forms.Label lblFolderSelection;
        private System.Windows.Forms.OpenFileDialog dlgOpenFolder;
        private System.Windows.Forms.Button btnResetFolderProcessor;
    }
}

