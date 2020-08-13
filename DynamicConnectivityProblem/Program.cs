using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicConnectivityProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of nodes:");
            int points = 0;
            points = Convert.ToInt32(Console.ReadLine());

            Approach1 ap1 = new Approach1(points);

            //Create route here
            ap1.Connected(3, 4);
            ap1.Connected(3, 8);
            ap1.Connected(1, 5);
            ap1.Connected(1, 2);

            //Find route here
            ap1.Find(5, 4);
            ap1.Find(8, 4);

            //Freeze the console
            Console.ReadLine();
        }
    }
}
