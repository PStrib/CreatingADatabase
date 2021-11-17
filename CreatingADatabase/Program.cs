using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatingADatabase.GUI;
using CreatingADatabase.Objects;

namespace CreatingADatabase
{
    static class Program
    {
        private static Database db = new Database();

        public static Database Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {  
           SetUpDataDirectoryPath();
           if (db.Connect())
            {
                MessageBox.Show("Database connection successful.", "Success!"); 
            }
            else
            {
                MessageBox.Show("Database connection failed.", "Error!");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainApp()); 
        }

        private static void SetUpDataDirectoryPath()
        {
            string debugPath = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = System.IO.Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
        }
    }
}
