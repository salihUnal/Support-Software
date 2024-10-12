namespace Support_Software
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            bool kontrol;

            Mutex mutex = new Mutex(true, "Program", out kontrol); //�rnek Mutex nesnesi olu�tural�m. 
            if (kontrol == false)
            {


                MessageBox.Show("Bu program zaten �al���yor.");
                return;
            }


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Support_Software());
            GC.KeepAlive(mutex); //Nesneyi kald�r�yoruz.
        }
    }
}