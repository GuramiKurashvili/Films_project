﻿namespace Films_project
{
    partial class LogIn
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
            this.Upload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PswField = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(130, 169);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(142, 47);
            this.Upload.TabIndex = 11;
            this.Upload.Text = "login";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // PswField
            // 
            this.PswField.Location = new System.Drawing.Point(40, 101);
            this.PswField.Name = "PswField";
            this.PswField.Size = new System.Drawing.Size(274, 22);
            this.PswField.TabIndex = 8;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(40, 59);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(274, 22);
            this.NameField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Autorization";
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(130, 231);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(142, 47);
            this.reg.TabIndex = 13;
            this.reg.Text = "Registration";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 309);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PswField);
            this.Controls.Add(this.NameField);
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PswField;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reg;
    }
}