using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez votre moyenne:");
            float moyenne = float.Parse(Console.ReadLine());

            if (moyenne < 10)
            {
                Console.WriteLine("Recalé");
                Console.ReadLine();
            }
            else if (moyenne >= 10 && moyenne < 12)
            {
                Console.WriteLine("Passable");
                Console.ReadLine();
            }
            else if (moyenne >= 12 && moyenne < 14)
            {
                Console.WriteLine("Assez bien");
                Console.ReadLine();
            }
            else if (moyenne >= 14 && moyenne < 16)
            {
                Console.WriteLine("Bien");
                Console.ReadLine();
            }
            else  
            {
                Console.WriteLine("Très bien");
                Console.ReadLine();
            }
        }
    }
}
