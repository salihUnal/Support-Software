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

        // Dinamik olarak Downloads klasörünü bulma
        public string GetDownloadFolder()
        {


            // Ayarlardan kayýtlý yolu okuyun
            string savedPath = Properties.Settings.Default.DownloadFolderPath;
            if (!string.IsNullOrEmpty(savedPath) && Directory.Exists(savedPath))
            {
                return savedPath;
            }

            // Kullanýcýdan dizin seçmesini isteyin
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Lütfen indirme klasörünü seçin";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen yolu ayarlara kaydedin
                    Properties.Settings.Default.DownloadFolderPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    return folderDialog.SelectedPath;
                }
            }

            MessageBox.Show("Klasör seçilmedi.");
            return string.Empty;
        }




        private void RdpDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = GetDownloadFolder();
            if (string.IsNullOrEmpty(klasorYolu))
            {
                MessageBox.Show("Geçerli bir Downloads klasör yolu bulunamadý.");
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
                    MessageBox.Show($"Toplam {deletedRdpFileCount} RDP dosyasý temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Harika!! \n Temizlemek için RDP dosyasý mevcut deðil.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }


        private void BybckDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = GetDownloadFolder(); // Dinamik Downloads klasörü
            if (string.IsNullOrEmpty(klasorYolu))
            {
                MessageBox.Show("Geçerli bir Downloads klasör yolu bulunamadý.");
                return;
            }

            string[] BybckDosyaUzantilari = { ".pdf" }; // Silmek istediðiniz PDF dosya uzantýlarý
            DirectoryInfo klasorbybck = new DirectoryInfo(klasorYolu);
            int deletedBybckFileCount = 0;

            try
            {
                // Her dosyayý kontrol et ve pdf dosyalarý sil
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

                // Silinen dosya sayýsýna göre mesaj göster
                if (deletedBybckFileCount > 0)
                {
                    MessageBox.Show($"Toplam {deletedBybckFileCount} PDF dosyasý temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Harika!! \n Temizlemek için PDF dosyasý mevcut deðil.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
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
