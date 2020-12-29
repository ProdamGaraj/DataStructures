using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Minion
    {
        public Minion()
        {
        }

        public Minion(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        int id { get; set; }
        string name { get; set; }
        int age { get; set; }
        public void GetMinion(Minion minion)
        {
            Console.WriteLine(id + " " + name + " " + age);
        }

    }


}
