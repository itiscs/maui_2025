using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp18.Models
{
    internal class Person
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Image { get; set; }


        public static List<Person> GetPeople()
        {
            var lst = new List<Person>();

            lst.Add(new Person()
            {
                Name = "Tom",
                Age = 20,
                Image = "user.png"
            });
            lst.Add(new Person()
            {
                Name = "Anna",
                Age = 25,
                Image = "user2.png"
            });

            lst.Add(new Person()
            {
                Name = "Jack",
                Age = 30,
                Image = "user.png"
            });
            lst.Add(new Person()
            {
                Name = "Susan",
                Age = 33,
                Image = "user2.png"
            });
            lst.Add(new Person()
            {
                Name = "Mike",
                Age = 40,
                Image = "user.png"
            });
            return lst;
        }
    }
}
