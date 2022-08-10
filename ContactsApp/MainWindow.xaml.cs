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
        public MainWindow()
        {
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
            List<Contact> contact;
            using (SQLiteConnection conn = new SQLiteConnection(App.dbpath))
            {
                conn.CreateTable<Contact>();
                contact = conn.Table<Contact>().ToList();
            }
            if (contact != null)
            {
                contentListItem.ItemsSource = contact;
            }
        }
    }
}
