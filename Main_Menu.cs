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
            string klasorYolu = @"C:\Users\Salih\OneDrive - 42 Bili�im A.�\Downloads\"; // Se�ilen klas�r�n yolu
                                                                                        //string uzanti = ".rdp"; // Silmek istedi�iniz dosya uzant�s�

            string[] RdpDosyaUzantilari = { ".rdp" }; // Silmek istedi�iniz RDP dosya uzant�lar�

            DirectoryInfo klasorrdp = new DirectoryInfo(klasorYolu);
            int deletedRdpFileCount = 0;

            //SilBelirliUzantiDosyalari(klasorYolu, dosyaUzantilari);


            // Kullan�c�n�n bir klas�r se�mesini sa�lay�n
            using (FolderBrowserDialog klasorSecici = new FolderBrowserDialog())
            {


                // Klas�rdeki dosyalar� al�n


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
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata olu�tu: {ex.Message}");
                }

                if (deletedRdpFileCount > 0)
                {

                    //MessageBox.Show($"{dosya.Extension} Dosyalar� silindi.");
                    MessageBox.Show($"Toplam {deletedRdpFileCount} RDP dosyas� temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("Temizlemek i�in Rdp Dosyas� Mevcut De�il", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               
            }

        }

        private void BybckDeleteButton_Click(object sender, EventArgs e)
        {
            string klasorYolu = @"C:\Users\Salih\OneDrive - 42 Bili�im A.�\Downloads\"; // Se�ilen klas�r�n yolu
            //string uzanti = ".rdp"; // Silmek istedi�iniz dosya uzant�s�
            DirectoryInfo klasorbybck = new DirectoryInfo(klasorYolu);
            string[] BybckDosyaUzantilari = { ".pdf" }; // Silmek istedi�iniz Pdf dosya uzant�lar�
            int deletedBybckFileCount = 0;


            // Kullan�c�n�n bir klas�r se�mesini sa�lay�n
            using (FolderBrowserDialog klasorSecici = new FolderBrowserDialog())
            {


                // Klas�rdeki dosyalar� al�n


                try
                {
                    // Her dosyay� kontrol et ve rdp  dosyalar� sil
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
                    MessageBox.Show($"Hata olu�tu: {ex.Message}");
                }


                if (deletedBybckFileCount > 0)
                {


                    //MessageBox.Show($"{dosya.Extension} Dosyalar� silindi.");
                    MessageBox.Show($"Toplam {deletedBybckFileCount} Pdf dosyas� temizlendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    MessageBox.Show("Temizlemek i�in Pdf Dosyas� Mevcut De�il" , "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
