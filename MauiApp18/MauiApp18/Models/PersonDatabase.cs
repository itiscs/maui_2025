using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp18.Models
{
    public class PersonsDatabase
    {
        SQLiteConnection Database;

        public PersonsDatabase()
        {
        }

        void Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            var result = Database.CreateTable<Person>();
        }

        public List<Person> GetPersons()
        {
            Init();
            return Database.Table<Person>().ToList();
        }


        public Person GetPerson(int id)
        {
            Init();
            return Database.Table<Person>().FirstOrDefault(p => p.Id == id);
        }

        public int SavePerson(Person item)
        {
            Init();
            if (item.Id != 0)
                return Database.Update(item);
            else
                return Database.Insert(item);
        }

        public int DeletePerson(Person item)
        {
            Init();
            return Database.Delete(item);
        }
        
    }
}
