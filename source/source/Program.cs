namespace source
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
<<<<<<< HEAD
        public static void Main(string[] args)
        {
            Table t = new Table();
            t.nhap();
            t.xuat();
        }
=======
        public static void Main(string[] args) {
            // tui fix cái merge để coi thử được ko nha

                }
>>>>>>> c515bc4c5c1d0c11c86c1eb4e7202042e1193023
    }
}