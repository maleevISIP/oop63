using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop63
{
    class treugole
    {
        private bool treugol;
        private double Alph;
        private double Bet;
        private double Gamm;

        public treugole(int l1, int l2, int l3)
        {
            double Alpha = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
            double Beta = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
            double Gamma = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {
                treugol = true;

                Alph = Alpha;
                Bet = Beta;
                Gamm = Gamma;
            }
            else
            {
                treugol = false;
            }

        }

        public void Display()
        {
            if (treugol == true)
            {
                Console.WriteLine($"\nТреугольник можно построить\n\n" +
                                  $"Углы\n" +
                                  $"Alpha : {Alph.ToString("##.##")}" +
                                  $"\nBeta : {Bet.ToString("##.##")}" +
                                  $"\nGamma: {Gamm.ToString("##.##")}");
            }
            else
                Console.WriteLine("\nТреугольник нельзя построить");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            treugole trget = new treugole(7, 7, 7);
            trget.Display();
            treugole trget1 = new treugole(6, 8, 4);
            trget1.Display();
            treugole trget2 = new treugole(32, 4, 13);
            trget2.Display();
            Console.ReadKey();
        }
    }
}
