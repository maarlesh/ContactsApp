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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SQLite;
using ContactsApp.Classes;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contact;
        public MainWindow()
        {
            contact = new List<Contact>();
            InitializeComponent();
            readDatabase();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddContactWIndow newContactWindow = new AddContactWIndow();
            newContactWindow.ShowDialog();
            readDatabase();
        }

        public void readDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {
                conn.CreateTable<Contact>();
                contact = (conn.Table<Contact>().ToList()).OrderBy(c => c.Name).ToList();
            }
            if (contact != null)
            {
                contentListItem.ItemsSource = contact;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox filter = (TextBox)sender;

            var filteredContact = contact.Where(c => c.Name.ToUpper().Contains(filter.Text.ToUpper())).ToList();

            contentListItem.ItemsSource = filteredContact;
        }
    }
}
