using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diakosztalyzat
{
    internal class Program
    {

        static int input()
        {
            Console.WriteLine("Adja meg a pontszámot!");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string output() {
            int points = input();
            if (points < 50) {
                return "Elégtelen";
            }
            else if(points < 60) {
                return "Elégséges";
            }
            else if (points < 80) {
                return "Közepes";
            }
            else if (points < 90)
            {
                return "jó";
            }
            else
            {
                return "jeles";
            }
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(output());
        }
    }
}
