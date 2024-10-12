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
        private string GetDownloadFolder()
        {
            string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            // OneDrive kontrol�
            string onedrivePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
            string onedriveDownloads = Path.Combine(onedrivePath, "Downloads");

            if (Directory.Exists(onedriveDownloads))
            {
                return onedriveDownloads;  // E�er OneDrive kullan�yorsa, OneDrive\Downloads yolunu d�nd�r
            }

            return downloadFolderPath;  // OneDrive kullan�lm�yorsa standart Downloads yolunu d�nd�r
        }


        private void RdpDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = GetDownloadFolder(); // Dinamik Downloads klas�r�

            string[] RdpDosyaUzantilari = { ".rdp" }; // Silmek istedi�iniz RDP dosya uzant�lar�

            DirectoryInfo klasorrdp = new DirectoryInfo(klasorYolu);
            int deletedRdpFileCount = 0;

            try
                {
                    // Her dosyay� kontrol et ve rdp  dosyalar� sil
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

             
         // Silinen dosya say�s�na g�re mesaj g�ster
                if (deletedRdpFileCount > 0)
            {
                MessageBox.Show($"Toplam {deletedRdpFileCount} RDP dosyas� temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Temizlemek i�in RDP dosyas� mevcut de�il.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Temizlemek i�in PDF dosyas� mevcut de�il.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
