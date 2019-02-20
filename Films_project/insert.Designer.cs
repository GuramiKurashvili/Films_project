namespace Films_project
{
    partial class insert
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
            this.NameField = new System.Windows.Forms.TextBox();
            this.GenreField = new System.Windows.Forms.TextBox();
            this.MarkField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(33, 30);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(274, 22);
            this.NameField.TabIndex = 0;
            // 
            // GenreField
            // 
            this.GenreField.Location = new System.Drawing.Point(33, 115);
            this.GenreField.Name = "GenreField";
            this.GenreField.Size = new System.Drawing.Size(274, 22);
            this.GenreField.TabIndex = 1;
            this.GenreField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MarkField
            // 
            this.MarkField.Location = new System.Drawing.Point(33, 72);
            this.MarkField.Name = "MarkField";
            this.MarkField.Size = new System.Drawing.Size(274, 22);
            this.MarkField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(130, 185);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(142, 47);
            this.Upload.TabIndex = 6;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 265);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarkField);
            this.Controls.Add(this.GenreField);
            this.Controls.Add(this.NameField);
            this.Name = "insert";
            this.ShowIcon = false;
            this.Text = "insert";
            this.Load += new System.EventHandler(this.insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox GenreField;
        private System.Windows.Forms.TextBox MarkField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Upload;
    }
}