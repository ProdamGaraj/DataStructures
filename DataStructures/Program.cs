using System;

namespace DataStructures
{

    class Program
    {
        public static void GetAllMinions(DoublyLinkedList<Minion> List)
        {
            foreach (Minion i in List)
            {
                i.GetMinion(i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DoublyLinkedList<Minion> List = new DoublyLinkedList<Minion>();
            Minion minion0 = new Minion(0, "Vasya", 2);
            Minion minion1 = new Minion(1, "Grisha", 23);
            Minion minion2 = new Minion(2, "Maksim", 93);
            Minion minion3 = new Minion(3, "Alex", 19);
            Minion minionNew = new Minion(4, "Temp", 9);
            GetAllMinions(List);
            List.Add(minion0);
            GetAllMinions(List);
            List.Add(minion1); 
            GetAllMinions(List);
            List.Add(minion2, 1);
            GetAllMinions(List);
            List.Add(minion3, 0);
            GetAllMinions(List);
            List.Remove(minion1);
            GetAllMinions(List);
            List.Remove(minion0);
            GetAllMinions(List);
            List.Remove(1);      
            GetAllMinions(List);
            List.Edit(0, minionNew);
            GetAllMinions(List);
        }
    }
}
