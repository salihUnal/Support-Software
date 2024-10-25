namespace Support_Software
{
    public partial class Support_Software : Form
    {
        public Support_Software()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Dinamik olarak Downloads klas�r�n� bulma
        public string GetDownloadFolder()
        {


            // Ayarlardan kay�tl� yolu okuyun
            string savedPath = Properties.Settings.Default.DownloadFolderPath;
            if (!string.IsNullOrEmpty(savedPath) && Directory.Exists(savedPath))
            {
                return savedPath;
            }

            // Kullan�c�dan dizin se�mesini isteyin
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "L�tfen indirme klas�r�n� se�in";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Se�ilen yolu ayarlara kaydedin
                    Properties.Settings.Default.DownloadFolderPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    return folderDialog.SelectedPath;
                }
            }

            MessageBox.Show("Klas�r se�ilmedi.");
            return string.Empty;
        }




        private void RdpDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = GetDownloadFolder();
            if (string.IsNullOrEmpty(klasorYolu))
            {
                MessageBox.Show("Ge�erli bir Downloads klas�r yolu bulunamad�.");
                return;
            }

            string[] RdpDosyaUzantilari = { ".rdp" };
            DirectoryInfo klasorrdp = new DirectoryInfo(klasorYolu);
            int deletedRdpFileCount = 0;

            try
            {
                foreach (FileInfo dosya in klasorrdp.GetFiles())
                {
                    foreach (var uzantirdp in RdpDosyaUzantilari)
                    {
                        if (dosya.Extension == uzantirdp)
                        {
                            dosya.Delete();
                            deletedRdpFileCount++;
                        }
                    }
                }

                if (deletedRdpFileCount > 0)
                {
                    MessageBox.Show($"Toplam {deletedRdpFileCount} RDP dosyas� temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Harika!! \n Temizlemek i�in RDP dosyas� mevcut de�il.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }
        }


        private void BybckDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = GetDownloadFolder(); // Dinamik Downloads klas�r�
            if (string.IsNullOrEmpty(klasorYolu))
            {
                MessageBox.Show("Ge�erli bir Downloads klas�r yolu bulunamad�.");
                return;
            }

            string[] BybckDosyaUzantilari = { ".pdf" }; // Silmek istedi�iniz PDF dosya uzant�lar�
            DirectoryInfo klasorbybck = new DirectoryInfo(klasorYolu);
            int deletedBybckFileCount = 0;

            try
            {
                // Her dosyay� kontrol et ve pdf dosyalar� sil
                foreach (FileInfo dosya in klasorbybck.GetFiles())
                {
                    foreach (var uzantibybck in BybckDosyaUzantilari)
                    {
                        if (dosya.Extension == uzantibybck)
                        {
                            dosya.Delete();
                            deletedBybckFileCount++;
                        }
                    }
                }

                // Silinen dosya say�s�na g�re mesaj g�ster
                if (deletedBybckFileCount > 0)
                {
                    MessageBox.Show($"Toplam {deletedBybckFileCount} PDF dosyas� temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Harika!! \n Temizlemek i�in PDF dosyas� mevcut de�il.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata olu�tu: {ex.Message}");
            }


        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.DateTimeLbl.Text = now.ToString("dd MMM yyyy dddd h:mm ");
        }

        private void CloseBtnDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void CloseBtn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }


}
