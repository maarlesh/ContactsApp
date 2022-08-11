using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ContactsApp.Classes;
using SQLite;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for SelectionWIndow.xaml
    /// </summary>
    public partial class SelectionWIndow : Window
    {
        Contact contact;
        public SelectionWIndow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {
                conn.CreateTable<Contact>();
                conn.Delete(this.contact);
                this.Close();
            }
        }
    }
}
