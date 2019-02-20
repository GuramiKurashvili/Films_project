namespace Films_project
{
    partial class Main
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
            this.LogOut = new System.Windows.Forms.Button();
            this.FeedBack = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.FeedBacks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(632, 408);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(147, 23);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // FeedBack
            // 
            this.FeedBack.Location = new System.Drawing.Point(632, 364);
            this.FeedBack.Name = "FeedBack";
            this.FeedBack.Size = new System.Drawing.Size(147, 23);
            this.FeedBack.TabIndex = 4;
            this.FeedBack.Text = "Feedback";
            this.FeedBack.UseVisualStyleBackColor = true;
            this.FeedBack.Click += new System.EventHandler(this.OnButton1Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 268);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellName);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(468, 364);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(147, 23);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(468, 408);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click1);
            // 
            // FeedBacks
            // 
            this.FeedBacks.Location = new System.Drawing.Point(315, 408);
            this.FeedBacks.Name = "FeedBacks";
            this.FeedBacks.Size = new System.Drawing.Size(147, 23);
            this.FeedBacks.TabIndex = 8;
            this.FeedBacks.Text = "Feedbacks";
            this.FeedBacks.UseVisualStyleBackColor = true;
            this.FeedBacks.Click += new System.EventHandler(this.FeedBacks_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(315, 364);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(147, 23);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.Update);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(329, 310);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(73, 23);
            this.minus.TabIndex = 12;
            this.minus.Text = "<";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(408, 310);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(73, 23);
            this.plus.TabIndex = 11;
            this.plus.Text = ">";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(521, 310);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(46, 17);
            this.PageLabel.TabIndex = 13;
            this.PageLabel.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageLabel);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedBacks);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.FeedBack);
            this.Controls.Add(this.dataGridView);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "GAU-MDB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button FeedBack;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button FeedBacks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label PageLabel;
    }
}

