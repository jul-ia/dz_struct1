using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct1
{
    class Program
    {

        public struct Train
        {
            public string dest;
            public int num;
            public string time;

           
            public void show()
            {
                Console.WriteLine("Train No {0}", num);
                Console.WriteLine("Destination: {0}", dest);
                Console.WriteLine("Departure at {0}", time);
                Console.WriteLine(new string('*', 30));

            }
        }

        public static int Comp(Train t1, Train t2)
        {
             return t1.num.CompareTo(t2.num);
        }


        public static int check(Train[] t, int n)
        {
            for (int i = 0; i < t.Length; i++)
                if (t[i].num == n)
                    return i;
            return -1;
        }

        static void Main(string[] args)
        {
            Train[] trains = new Train[3];
            for(int i = 0; i < trains.Length; i++)
            {
                Console.Write("Enter destination: ");
                trains[i].dest = Console.ReadLine();
                Console.Write("Enter train number: ");
                int.TryParse(Console.ReadLine(), out trains[i].num);
                Console.Write("Enter time of departure: ");
                trains[i].time = Console.ReadLine();
                Console.WriteLine(new string('-', 30));
            }
            Console.WriteLine();
            Array.Sort(trains, Comp);


            for (int i = 0; i < trains.Length; i++)
                trains[i].show();

            int n;
            Console.Write("\nEnter number of train: ");
            int.TryParse(Console.ReadLine(), out n);
            int ind = check(trains, n);
            if (ind != -1)
                trains[ind].show();
            else
                Console.WriteLine("Train is not found.");

            Console.ReadLine();
        }
    }
}
