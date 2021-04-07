using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokProgramu
{
    class Program
    {
        static void Main(string[] args)
        {
            Vypocty vypocty = new Vypocty();
            Console.WriteLine("Napiš X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Napiš N");
            int n = Convert.ToInt32(Console.ReadLine());
            vypocty.ForType(x, n);
        }

    }
  public class Vypocty
    {
        double Factorial(int A)
        {
            if (A == 1 || A == 0) return 1;
            else return A * Factorial(A - 1);
        }
      public  void ForType(int x, int n)
        {
            double Vysledek = 1;


            for (int s = 0; s < n; s++)
            {
                if (s % 2 == 0)
                {
                    Vysledek -= (x ^ n) / Factorial(n);

                }
                else
                {
                    Vysledek += (x ^ n) / Factorial(n);

                }
            }
            Console.WriteLine(Vysledek);
            Console.ReadLine();
        }
    }
}
