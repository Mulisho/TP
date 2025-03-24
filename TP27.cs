using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
       
public class TableauNombres0_20
    {
        public static void Main(string[] args)
        {
            int[] tableau = new int[50];
            int index = 0;

            Console.WriteLine("Entrez des nombres entiers entre 0 et 20 (-1 pour arrêter) :");

            while (index < 50)
            {
                int nombre = Convert.ToInt32(Console.ReadLine());

                if (nombre == -1)
                {
                    break;
                }
                else if (nombre >= 0 && nombre <= 20)
                {
                    tableau[index] = nombre;
                    index++;
                }
                else
                {
                    Console.WriteLine("Nombre invalide. Veuillez entrer un nombre entre 0 et 20.");
                }
            }

            Console.WriteLine("Les nombres entrés sont :");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}
}
