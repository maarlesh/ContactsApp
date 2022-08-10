using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp.Classes
{
    public class Contact
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
