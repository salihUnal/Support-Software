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

        private void RdpDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = @"C:\Users\Salih\OneDrive - 42 Biliþim A.Þ\Downloads\"; // Seçilen klasörün yolu
                                                                                        //string uzanti = ".rdp"; // Silmek istediðiniz dosya uzantýsý

            string[] RdpDosyaUzantilari = { ".rdp" }; // Silmek istediðiniz RDP dosya uzantýlarý

            DirectoryInfo klasorrdp = new DirectoryInfo(klasorYolu);
            int deletedRdpFileCount = 0;

            //SilBelirliUzantiDosyalari(klasorYolu, dosyaUzantilari);


            // Kullanýcýnýn bir klasör seçmesini saðlayýn
            using (FolderBrowserDialog klasorSecici = new FolderBrowserDialog())
            {


                // Klasördeki dosyalarý alýn


                try
                {
                    // Her dosyayý kontrol et ve rdp  dosyalarý sil
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
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluþtu: {ex.Message}");
                }

                if (deletedRdpFileCount > 0)
                {

                    //MessageBox.Show($"{dosya.Extension} Dosyalarý silindi.");
                    MessageBox.Show($"Toplam {deletedRdpFileCount} RDP dosyasý temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("Temizlemek için Rdp Dosyasý Mevcut Deðil", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               
            }

        }

        private void BybckDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = @"C:\Users\Salih\OneDrive - 42 Biliþim A.Þ\Downloads\"; // Seçilen klasörün yolu
            //string uzanti = ".rdp"; // Silmek istediðiniz dosya uzantýsý
            DirectoryInfo klasorbybck = new DirectoryInfo(klasorYolu);
            string[] BybckDosyaUzantilari = { ".pdf" }; // Silmek istediðiniz Pdf dosya uzantýlarý
            int deletedBybckFileCount = 0;


            // Kullanýcýnýn bir klasör seçmesini saðlayýn
            using (FolderBrowserDialog klasorSecici = new FolderBrowserDialog())
            {


                // Klasördeki dosyalarý alýn


                try
                {
                    // Her dosyayý kontrol et ve rdp  dosyalarý sil
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
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluþtu: {ex.Message}");
                }


                if (deletedBybckFileCount > 0)
                {


                    //MessageBox.Show($"{dosya.Extension} Dosyalarý silindi.");
                    MessageBox.Show($"Toplam {deletedBybckFileCount} Pdf dosyasý temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("Temizlemek için Pdf Dosyasý Mevcut Deðil" , "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
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
    }


}
