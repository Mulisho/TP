using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
      
public class RacinesCarrées
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Entrez un nombre (0 pour arrêter) :");
                double nombre = Convert.ToDouble(Console.ReadLine());

                if (nombre == 0)
                {
                    break; // Sortir de la boucle si l'utilisateur entre 0
                }
                else if (nombre < 0)
                {
                    Console.WriteLine("Nombre négatif. La racine carrée n'est pas définie.");
                }
                else
                {
                    double racine = Math.Sqrt(nombre);
                    Console.WriteLine($"La racine carrée de {nombre} est : {racine}");
                }
            }
        }
    }
}
}
