using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
      

public class ConversionTemperature
    {
        public static void Main(string[] args)
        {
            // Déclarer les variables pour la température en Celsius et Fahrenheit
            double celsius, fahrenheit;

            // Demander à l'utilisateur d'entrer la température en Celsius
            Console.Write("Entrez la température en degrés Celsius : ");
            celsius = Convert.ToDouble(Console.ReadLine());

            // Convertir Celsius en Fahrenheit
            fahrenheit = (celsius * 1.8) + 32;

            // Afficher le résultat
            Console.WriteLine($"{celsius} degrés Celsius équivaut à {fahrenheit} degrés Fahrenheit.");
        }
    }
}
}
