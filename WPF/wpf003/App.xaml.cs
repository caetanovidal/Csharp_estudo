using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace wpf003
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static string databaseName = "Contact.db";
        //public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string folderPath = @"C:\Users\Windows\estudos\WPF\DatabaseSQLite";
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);

    }
}       
        