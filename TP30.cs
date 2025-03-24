using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
      
public class AffichageISIG
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre de fois à afficher ISIG/GOMA :");
            int nombreDeFois = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nombreDeFois; i++)
            {
                Console.WriteLine("ISIG/GOMA");
            }
        }
    }
}
}
