using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*public static string dbname = "Contacts.db";
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string dbpath = System.IO.Path.Combine(path, dbname);*/
        public static string dbpath = "E:/Courses/Windows Presentation Foundation/ContactsApp/Databases/Contacts.db";
    }
}
