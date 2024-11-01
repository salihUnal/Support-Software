﻿namespace Support_Software
{
    partial class Support_Software
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support_Software));
            MainPanel = new Panel();
            WarnTextBox = new TextBox();
            PdfLbl = new Label();
            RdpLbl = new Label();
            BybckDeleteButton = new Button();
            TopPanel = new Panel();
            label1 = new Label();
            CloseBtnTop = new Button();
            SidePanel = new Panel();
            CloseBtnDown = new Button();
            DateTimeLbl = new Label();
            VersionLbl = new Label();
            OwnerLbl = new Label();
            pictureBox1 = new PictureBox();
            RdpDeleteButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            MainPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(button1);
            MainPanel.Controls.Add(WarnTextBox);
            MainPanel.Controls.Add(PdfLbl);
            MainPanel.Controls.Add(RdpLbl);
            MainPanel.Controls.Add(BybckDeleteButton);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Controls.Add(SidePanel);
            MainPanel.Controls.Add(RdpDeleteButton);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(418, 348);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += panel1_Paint;
            // 
            // WarnTextBox
            // 
            WarnTextBox.BackColor = Color.FromArgb(46, 51, 73);
            WarnTextBox.BorderStyle = BorderStyle.None;
            WarnTextBox.ForeColor = Color.OrangeRed;
            WarnTextBox.Location = new Point(171, 237);
            WarnTextBox.Multiline = true;
            WarnTextBox.Name = "WarnTextBox";
            WarnTextBox.ReadOnly = true;
            WarnTextBox.Size = new Size(230, 66);
            WarnTextBox.TabIndex = 9;
            WarnTextBox.Text = "                             Dikkat!! \n                           \"Pdf Sil\" Butonu İndirilenler Klasörünüzdeki Tüm \"Pdf\" Dosyalarınızı Siler!!";
            WarnTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PdfLbl
            // 
            PdfLbl.AutoSize = true;
            PdfLbl.FlatStyle = FlatStyle.System;
            PdfLbl.Font = new Font("Gabriola", 12F, FontStyle.Bold | FontStyle.Italic);
            PdfLbl.ForeColor = Color.Orchid;
            PdfLbl.Location = new Point(298, 114);
            PdfLbl.Name = "PdfLbl";
            PdfLbl.Size = new Size(113, 29);
            PdfLbl.TabIndex = 4;
            PdfLbl.Text = "Pdf Dosyaları Sil";
            PdfLbl.Click += BybckDeleteButton_Click;
            // 
            // RdpLbl
            // 
            RdpLbl.AutoSize = true;
            RdpLbl.FlatStyle = FlatStyle.System;
            RdpLbl.Font = new Font("Gabriola", 12F, FontStyle.Bold | FontStyle.Italic);
            RdpLbl.ForeColor = Color.Orchid;
            RdpLbl.Location = new Point(159, 114);
            RdpLbl.Name = "RdpLbl";
            RdpLbl.Size = new Size(118, 29);
            RdpLbl.TabIndex = 3;
            RdpLbl.Text = "Rdp Dosyaları Sil";
            RdpLbl.Click += RdpDeleteButton_Click;
            // 
            // BybckDeleteButton
            // 
            BybckDeleteButton.BackgroundImage = (Image)resources.GetObject("BybckDeleteButton.BackgroundImage");
            BybckDeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            BybckDeleteButton.FlatAppearance.BorderSize = 0;
            BybckDeleteButton.FlatStyle = FlatStyle.Flat;
            BybckDeleteButton.Location = new Point(298, 74);
            BybckDeleteButton.Name = "BybckDeleteButton";
            BybckDeleteButton.Size = new Size(81, 88);
            BybckDeleteButton.TabIndex = 2;
            BybckDeleteButton.UseVisualStyleBackColor = true;
            BybckDeleteButton.Click += BybckDeleteButton_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(46, 51, 73);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(CloseBtnTop);
            TopPanel.Location = new Point(152, 3);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(266, 64);
            TopPanel.TabIndex = 1;
            TopPanel.MouseDown += panel2_MouseDown;
            TopPanel.MouseMove += panel2_MouseMove;
            TopPanel.MouseUp += panel2_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Gabriola", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.PaleGoldenrod;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 4;
            label1.Text = "Support Software";
            // 
            // CloseBtnTop
            // 
            CloseBtnTop.FlatAppearance.BorderSize = 0;
            CloseBtnTop.FlatStyle = FlatStyle.Flat;
            CloseBtnTop.Font = new Font("Marlett", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            CloseBtnTop.ForeColor = Color.White;
            CloseBtnTop.Location = new Point(241, 0);
            CloseBtnTop.Name = "CloseBtnTop";
            CloseBtnTop.Size = new Size(25, 25);
            CloseBtnTop.TabIndex = 0;
            CloseBtnTop.Text = "X";
            CloseBtnTop.UseVisualStyleBackColor = true;
            CloseBtnTop.Click += closeButton_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(24, 30, 50);
            SidePanel.Controls.Add(CloseBtnDown);
            SidePanel.Controls.Add(DateTimeLbl);
            SidePanel.Controls.Add(VersionLbl);
            SidePanel.Controls.Add(OwnerLbl);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Location = new Point(3, 3);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(150, 345);
            SidePanel.TabIndex = 0;
            SidePanel.MouseDown += panel1_MouseMove;
            SidePanel.MouseMove += panel1_MouseMove;
            SidePanel.MouseUp += panel1_MouseUp;
            // 
            // CloseBtnDown
            // 
            CloseBtnDown.FlatAppearance.BorderColor = Color.Gray;
            CloseBtnDown.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            CloseBtnDown.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseBtnDown.FlatStyle = FlatStyle.Flat;
            CloseBtnDown.Font = new Font("Marlett", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            CloseBtnDown.ForeColor = Color.White;
            CloseBtnDown.Location = new Point(40, 234);
            CloseBtnDown.Name = "CloseBtnDown";
            CloseBtnDown.Size = new Size(55, 25);
            CloseBtnDown.TabIndex = 3;
            CloseBtnDown.Text = "Kapat";
            CloseBtnDown.UseVisualStyleBackColor = true;
            CloseBtnDown.Click += CloseBtnDown_Click;
            // 
            // DateTimeLbl
            // 
            DateTimeLbl.AutoSize = true;
            DateTimeLbl.FlatStyle = FlatStyle.System;
            DateTimeLbl.Font = new Font("Jupitex", 8.25F);
            DateTimeLbl.Location = new Point(9, 298);
            DateTimeLbl.Name = "DateTimeLbl";
            DateTimeLbl.Size = new Size(50, 11);
            DateTimeLbl.TabIndex = 5;
            DateTimeLbl.Text = "DateTime";
            // 
            // VersionLbl
            // 
            VersionLbl.AutoSize = true;
            VersionLbl.FlatStyle = FlatStyle.System;
            VersionLbl.Font = new Font("Jupitex", 8.25F);
            VersionLbl.Location = new Point(9, 329);
            VersionLbl.Name = "VersionLbl";
            VersionLbl.Size = new Size(68, 11);
            VersionLbl.TabIndex = 2;
            VersionLbl.Text = "Version 1.0.10";
            // 
            // OwnerLbl
            // 
            OwnerLbl.AutoSize = true;
            OwnerLbl.FlatStyle = FlatStyle.System;
            OwnerLbl.Font = new Font("Jupitex", 8.25F);
            OwnerLbl.Location = new Point(9, 6);
            OwnerLbl.Name = "OwnerLbl";
            OwnerLbl.Size = new Size(117, 11);
            OwnerLbl.TabIndex = 1;
            OwnerLbl.Text = "Powered By Salih Unal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RdpDeleteButton
            // 
            RdpDeleteButton.BackgroundImage = (Image)resources.GetObject("RdpDeleteButton.BackgroundImage");
            RdpDeleteButton.BackgroundImageLayout = ImageLayout.Stretch;
            RdpDeleteButton.FlatAppearance.BorderSize = 0;
            RdpDeleteButton.FlatStyle = FlatStyle.Flat;
            RdpDeleteButton.Location = new Point(171, 74);
            RdpDeleteButton.Name = "RdpDeleteButton";
            RdpDeleteButton.Size = new Size(81, 88);
            RdpDeleteButton.TabIndex = 6;
            RdpDeleteButton.UseVisualStyleBackColor = true;
            RdpDeleteButton.Click += RdpDeleteButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(278, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Support_Software
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(423, 352);
            Controls.Add(MainPanel);
            ForeColor = Color.FromArgb(151, 161, 178);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Support_Software";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support_Software";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private Panel MainPanel;
        private Panel TopPanel;
        private Panel SidePanel;
        private Button BybckDeleteButton;
        private PictureBox pictureBox1;
        private Label VersionLbl;
        private Label OwnerLbl;
        private Button CloseBtnTop;
        private Label PdfLbl;
        private Label RdpLbl;
        private Label DateTimeLbl;
        private System.Windows.Forms.Timer timer1;
        private Button RdpDeleteButton;
        private Label label1;
        private Button CloseBtnDown;
        private TextBox WarnTextBox;
        private Button button1;
        //private Button CloseBtn;
    }
}
