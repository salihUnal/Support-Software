namespace Support_Software
{
    partial class RdpInfoSc
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
            CloseRdp = new Button();
            SuspendLayout();
            // 
            // CloseRdp
            // 
            CloseRdp.Location = new Point(88, 78);
            CloseRdp.Name = "CloseRdp";
            CloseRdp.Size = new Size(75, 23);
            CloseRdp.TabIndex = 0;
            CloseRdp.Text = "button1";
            CloseRdp.UseVisualStyleBackColor = true;
            // 
            // RdpInfoSc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseRdp;
            ClientSize = new Size(283, 131);
            Controls.Add(CloseRdp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RdpInfoSc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RdpInfoSc";
            ResumeLayout(false);
        }

        #endregion

        private Button CloseRdp;
    }
}