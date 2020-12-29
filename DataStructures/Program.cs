using System;

namespace DataStructures
{

    class Program
    {
        public static void GetTrain(DoublyLinkedList<Vagon> Train)
        {
            foreach (Vagon i in Train)
            {
                i.GetVagon(i);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            DoublyLinkedList<Vagon> Train = new DoublyLinkedList<Vagon>();

            Vagon vagon0 = new Vagon(0, 10, 15);
            Vagon vagon1 = new Vagon(1, 15, 15);
            Vagon vagon2 = new Vagon(2, 20, 15);
            Vagon vagon3 = new Vagon(3, 25, 15);

            GetTrain(Train);
            Train.Add(vagon0);
            GetTrain(Train);
            Train.Add(vagon1);
            GetTrain(Train);
            Train.Add(vagon2);
            GetTrain(Train);
            Train.Add(vagon3, 0);
            GetTrain(Train);
            Train.Remove(vagon1);
            GetTrain(Train);
            Train.Remove(1);
            GetTrain(Train);
            Train.Edit(0, new Vagon(4, 120, 12));
            GetTrain(Train);
        }
    }
}
