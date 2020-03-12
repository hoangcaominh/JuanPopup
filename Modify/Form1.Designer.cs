namespace Modify
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DataList = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Delete = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditGroup = new System.Windows.Forms.GroupBox();
            this.NewGroup = new System.Windows.Forms.GroupBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ContentText = new System.Windows.Forms.TextBox();
            this.HeaderText = new System.Windows.Forms.TextBox();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EditGroup.SuspendLayout();
            this.NewGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(6, 48);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DataList
            // 
            this.DataList.FormattingEnabled = true;
            this.DataList.Location = new System.Drawing.Point(87, 19);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(615, 186);
            this.DataList.TabIndex = 3;
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Location = new System.Drawing.Point(6, 77);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 106);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditGroup
            // 
            this.EditGroup.Controls.Add(this.SaveButton);
            this.EditGroup.Controls.Add(this.DataList);
            this.EditGroup.Controls.Add(this.EditButton);
            this.EditGroup.Controls.Add(this.Delete);
            this.EditGroup.Controls.Add(this.AddButton);
            this.EditGroup.Location = new System.Drawing.Point(12, 12);
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.Size = new System.Drawing.Size(708, 215);
            this.EditGroup.TabIndex = 5;
            this.EditGroup.TabStop = false;
            this.EditGroup.Text = "Edit";
            // 
            // NewGroup
            // 
            this.NewGroup.Controls.Add(this.ModeLabel);
            this.NewGroup.Controls.Add(this.ApplyButton);
            this.NewGroup.Controls.Add(this.ContentText);
            this.NewGroup.Controls.Add(this.HeaderText);
            this.NewGroup.Controls.Add(this.AuthorText);
            this.NewGroup.Controls.Add(this.HeaderLabel);
            this.NewGroup.Controls.Add(this.ContentLabel);
            this.NewGroup.Controls.Add(this.AuthorLabel);
            this.NewGroup.Location = new System.Drawing.Point(12, 233);
            this.NewGroup.Name = "NewGroup";
            this.NewGroup.Size = new System.Drawing.Size(708, 125);
            this.NewGroup.TabIndex = 6;
            this.NewGroup.TabStop = false;
            this.NewGroup.Text = "New";
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(6, 45);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(0, 13);
            this.ModeLabel.TabIndex = 8;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(6, 19);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ContentText
            // 
            this.ContentText.Location = new System.Drawing.Point(138, 73);
            this.ContentText.Multiline = true;
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(564, 46);
            this.ContentText.TabIndex = 6;
            // 
            // HeaderText
            // 
            this.HeaderText.Location = new System.Drawing.Point(138, 47);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(564, 20);
            this.HeaderText.TabIndex = 5;
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(138, 21);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(564, 20);
            this.AuthorText.TabIndex = 4;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(90, 50);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeaderLabel.Size = new System.Drawing.Size(42, 13);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "Header";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(88, 76);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(94, 24);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "Author";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 370);
            this.Controls.Add(this.NewGroup);
            this.Controls.Add(this.EditGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Modify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EditGroup.ResumeLayout(false);
            this.NewGroup.ResumeLayout(false);
            this.NewGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox DataList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox EditGroup;
        private System.Windows.Forms.GroupBox NewGroup;
        private System.Windows.Forms.TextBox ContentText;
        private System.Windows.Forms.TextBox HeaderText;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label ModeLabel;
    }
}

