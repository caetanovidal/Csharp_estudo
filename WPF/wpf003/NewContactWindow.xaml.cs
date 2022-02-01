﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wpf003.Classes;

namespace wpf003
{
    /// <summary>
    /// Lógica interna para NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();

            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text
            };
            
            //string databaseName = "Contact.db";
            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string databasePath = System.IO.Path.Combine(folderPath, databaseName);

            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            } 
            
            Close();
        }
    }
}
