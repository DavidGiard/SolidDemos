namespace SOLID_Lab
{
    partial class Form1
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
            this.GetPhotoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.SaveDataButton = new System.Windows.Forms.Button();
            this.AnalyzePhotoButton = new System.Windows.Forms.Button();
            this.PhotoPathLabel = new System.Windows.Forms.Label();
            this.MakeCopyButton = new System.Windows.Forms.Button();
            this.AnalysisResultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPhotoButton
            // 
            this.GetPhotoButton.Location = new System.Drawing.Point(12, 0);
            this.GetPhotoButton.Name = "GetPhotoButton";
            this.GetPhotoButton.Size = new System.Drawing.Size(337, 61);
            this.GetPhotoButton.TabIndex = 0;
            this.GetPhotoButton.Text = "Get Photo";
            this.GetPhotoButton.UseVisualStyleBackColor = true;
            this.GetPhotoButton.Click += new System.EventHandler(this.GetPhotoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 247);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(211, 353);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(326, 26);
            this.FirstNameTextbox.TabIndex = 4;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(211, 394);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(326, 26);
            this.LastNameTextbox.TabIndex = 5;
            // 
            // SaveDataButton
            // 
            this.SaveDataButton.Location = new System.Drawing.Point(565, 353);
            this.SaveDataButton.Name = "SaveDataButton";
            this.SaveDataButton.Size = new System.Drawing.Size(298, 71);
            this.SaveDataButton.TabIndex = 6;
            this.SaveDataButton.Text = "Save Data";
            this.SaveDataButton.UseVisualStyleBackColor = true;
            this.SaveDataButton.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // AnalyzePhotoButton
            // 
            this.AnalyzePhotoButton.Location = new System.Drawing.Point(16, 551);
            this.AnalyzePhotoButton.Name = "AnalyzePhotoButton";
            this.AnalyzePhotoButton.Size = new System.Drawing.Size(298, 67);
            this.AnalyzePhotoButton.TabIndex = 7;
            this.AnalyzePhotoButton.Text = "Analyze Photo";
            this.AnalyzePhotoButton.UseVisualStyleBackColor = true;
            this.AnalyzePhotoButton.Click += new System.EventHandler(this.AnalyzePhotoButton_Click);
            // 
            // PhotoPathLabel
            // 
            this.PhotoPathLabel.AutoSize = true;
            this.PhotoPathLabel.Location = new System.Drawing.Point(12, 64);
            this.PhotoPathLabel.Name = "PhotoPathLabel";
            this.PhotoPathLabel.Size = new System.Drawing.Size(21, 20);
            this.PhotoPathLabel.TabIndex = 8;
            this.PhotoPathLabel.Text = "   ";
            // 
            // MakeCopyButton
            // 
            this.MakeCopyButton.Location = new System.Drawing.Point(16, 459);
            this.MakeCopyButton.Name = "MakeCopyButton";
            this.MakeCopyButton.Size = new System.Drawing.Size(298, 86);
            this.MakeCopyButton.TabIndex = 9;
            this.MakeCopyButton.Text = "Make backup copy of photo";
            this.MakeCopyButton.UseVisualStyleBackColor = true;
            this.MakeCopyButton.Click += new System.EventHandler(this.MakeCopyButton_Click);
            // 
            // AnalysisResultsLabel
            // 
            this.AnalysisResultsLabel.AutoSize = true;
            this.AnalysisResultsLabel.Location = new System.Drawing.Point(20, 644);
            this.AnalysisResultsLabel.Name = "AnalysisResultsLabel";
            this.AnalysisResultsLabel.Size = new System.Drawing.Size(33, 20);
            this.AnalysisResultsLabel.TabIndex = 10;
            this.AnalysisResultsLabel.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 822);
            this.Controls.Add(this.AnalysisResultsLabel);
            this.Controls.Add(this.MakeCopyButton);
            this.Controls.Add(this.PhotoPathLabel);
            this.Controls.Add(this.AnalyzePhotoButton);
            this.Controls.Add(this.SaveDataButton);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GetPhotoButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPhotoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.Button SaveDataButton;
        private System.Windows.Forms.Button AnalyzePhotoButton;
        private System.Windows.Forms.Label PhotoPathLabel;
        private System.Windows.Forms.Button MakeCopyButton;
        private System.Windows.Forms.Label AnalysisResultsLabel;
    }
}

