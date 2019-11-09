namespace PublishingHouseManagmentSystem
{
    partial class PublishForm
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
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.PublishButton = new System.Windows.Forms.Button();
            this.PublisherName = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PagesAmount = new System.Windows.Forms.NumericUpDown();
            this.StartPage = new System.Windows.Forms.NumericUpDown();
            this.StartPageLabel = new System.Windows.Forms.Label();
            this.EndPage = new System.Windows.Forms.NumericUpDown();
            this.EndPageLabel = new System.Windows.Forms.Label();
            this.LinkAddress = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AuthorsCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndPage)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::PublishingHouseManagmentSystem.Properties.Resources.close_button__1_;
            this.ExitButton.Location = new System.Drawing.Point(144, 373);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(16, 16);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton.TabIndex = 27;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PublishButton
            // 
            this.PublishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.PublishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublishButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishButton.ForeColor = System.Drawing.Color.White;
            this.PublishButton.Location = new System.Drawing.Point(23, 313);
            this.PublishButton.Name = "PublishButton";
            this.PublishButton.Size = new System.Drawing.Size(270, 37);
            this.PublishButton.TabIndex = 26;
            this.PublishButton.Text = "Publish";
            this.PublishButton.UseVisualStyleBackColor = false;
            this.PublishButton.Click += new System.EventHandler(this.PublishButton_Click);
            // 
            // PublisherName
            // 
            this.PublisherName.BackColor = System.Drawing.SystemColors.Control;
            this.PublisherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublisherName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PublisherName.Location = new System.Drawing.Point(23, 128);
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.Size = new System.Drawing.Size(270, 14);
            this.PublisherName.TabIndex = 24;
            // 
            // TitleTxt
            // 
            this.TitleTxt.BackColor = System.Drawing.SystemColors.Control;
            this.TitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.TitleTxt.Location = new System.Drawing.Point(23, 76);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(270, 14);
            this.TitleTxt.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(20, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "PublisherCompany";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(20, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Publish ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(20, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "PagesAmount";
            // 
            // PagesAmount
            // 
            this.PagesAmount.Location = new System.Drawing.Point(23, 272);
            this.PagesAmount.Name = "PagesAmount";
            this.PagesAmount.Size = new System.Drawing.Size(80, 20);
            this.PagesAmount.TabIndex = 30;
            // 
            // StartPage
            // 
            this.StartPage.Location = new System.Drawing.Point(119, 272);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(80, 20);
            this.StartPage.TabIndex = 32;
            // 
            // StartPageLabel
            // 
            this.StartPageLabel.AutoSize = true;
            this.StartPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartPageLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.StartPageLabel.Location = new System.Drawing.Point(116, 251);
            this.StartPageLabel.Name = "StartPageLabel";
            this.StartPageLabel.Size = new System.Drawing.Size(62, 18);
            this.StartPageLabel.TabIndex = 31;
            this.StartPageLabel.Text = "Start Page";
            // 
            // EndPage
            // 
            this.EndPage.Location = new System.Drawing.Point(213, 272);
            this.EndPage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EndPage.Name = "EndPage";
            this.EndPage.Size = new System.Drawing.Size(80, 20);
            this.EndPage.TabIndex = 34;
            // 
            // EndPageLabel
            // 
            this.EndPageLabel.AutoSize = true;
            this.EndPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndPageLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.EndPageLabel.Location = new System.Drawing.Point(210, 251);
            this.EndPageLabel.Name = "EndPageLabel";
            this.EndPageLabel.Size = new System.Drawing.Size(58, 18);
            this.EndPageLabel.TabIndex = 33;
            this.EndPageLabel.Text = "End Page";
            // 
            // LinkAddress
            // 
            this.LinkAddress.BackColor = System.Drawing.SystemColors.Control;
            this.LinkAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.LinkAddress.Location = new System.Drawing.Point(23, 178);
            this.LinkAddress.Name = "LinkAddress";
            this.LinkAddress.Size = new System.Drawing.Size(270, 14);
            this.LinkAddress.TabIndex = 36;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.AddressLabel.Location = new System.Drawing.Point(20, 158);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(72, 18);
            this.AddressLabel.TabIndex = 35;
            this.AddressLabel.Text = "LinkAddress";
            // 
            // AuthorsCombo
            // 
            this.AuthorsCombo.FormattingEnabled = true;
            this.AuthorsCombo.Location = new System.Drawing.Point(23, 216);
            this.AuthorsCombo.Name = "AuthorsCombo";
            this.AuthorsCombo.Size = new System.Drawing.Size(270, 21);
            this.AuthorsCombo.TabIndex = 37;
            this.AuthorsCombo.Text = "Authors";
            // 
            // PublishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 401);
            this.Controls.Add(this.AuthorsCombo);
            this.Controls.Add(this.LinkAddress);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EndPage);
            this.Controls.Add(this.EndPageLabel);
            this.Controls.Add(this.StartPage);
            this.Controls.Add(this.StartPageLabel);
            this.Controls.Add(this.PagesAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PublishButton);
            this.Controls.Add(this.PublisherName);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PublishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PublishForm";
            this.Load += new System.EventHandler(this.PublishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.Button PublishButton;
        private System.Windows.Forms.TextBox PublisherName;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PagesAmount;
        private System.Windows.Forms.NumericUpDown StartPage;
        private System.Windows.Forms.Label StartPageLabel;
        private System.Windows.Forms.NumericUpDown EndPage;
        private System.Windows.Forms.Label EndPageLabel;
        private System.Windows.Forms.TextBox LinkAddress;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.ComboBox AuthorsCombo;
    }
}