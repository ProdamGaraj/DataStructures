using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Vagon
    {
        public Vagon()
        {
        }

        public Vagon(int id, int seatsAmount, int age)
        {
            this.id = id;
            this.seatsAmount = seatsAmount;
            this.age = age;
        }

        public int id { get; set; }
        public int seatsAmount { get; set; }
        public int age { get; set; }

        public void GetVagon(Vagon vagon)
        {
            Console.WriteLine(id + " " + seatsAmount + " " + age);
        }

    }
}
