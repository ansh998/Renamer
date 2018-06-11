namespace Renamer
{
    partial class Renamer
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
            this.path = new System.Windows.Forms.TextBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.TreeView();
            this.ren = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(13, 13);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(336, 20);
            this.path.TabIndex = 0;
            this.path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.path_KeyPress);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(369, 13);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // files
            // 
            this.files.Location = new System.Drawing.Point(13, 61);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(431, 485);
            this.files.TabIndex = 2;
            // 
            // ren
            // 
            this.ren.Location = new System.Drawing.Point(13, 561);
            this.ren.Name = "ren";
            this.ren.Size = new System.Drawing.Size(75, 23);
            this.ren.TabIndex = 3;
            this.ren.Text = "Rename";
            this.ren.UseVisualStyleBackColor = true;
            this.ren.Click += new System.EventHandler(this.ren_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Renamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 605);
            this.Controls.Add(this.ren);
            this.Controls.Add(this.files);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.path);
            this.Name = "Renamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.TreeView files;
        private System.Windows.Forms.Button ren;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
    }
}

