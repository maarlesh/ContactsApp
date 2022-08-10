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
    /// Interaction logic for AddContactWIndow.xaml
    /// </summary>
    public partial class AddContactWIndow : Window
    {
        public AddContactWIndow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Name = nameTextBox.Text;
            contact.Email = emailTextBox.Text;
            contact.Phone  = phnoTextBox.Text;
            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {
                conn.CreateTable<Contact>();
                conn.Insert(contact);
            }
            this.Close();
        }
    }
}
