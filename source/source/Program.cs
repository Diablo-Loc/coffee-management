using source.Models;

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
            https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }

        public static void Main(string[] args)
        {
            Table t = new Table();
            t.nhap();
            t.xuat();
        }


    }
}