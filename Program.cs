using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_Dictionnaires
{
    class Program
    {
        static void Main(string[] args)

           
        {
            Console.WriteLine("veuillez choisir un premier mot  : " );
            string premiere = Console.ReadLine();
            Console.WriteLine("veuillez choisir un premier mot  : ");
            string deuxieme = Console.ReadLine();
            Console.WriteLine("veuillez choisir un premier mot  : ");
            string troisieme = Console.ReadLine();

            Console.WriteLine("");

            Dictionary<char, string> dictionnaire = new Dictionary<char, string>
            {
                {'a',  premiere },
                {'b', deuxieme },
                {'c', troisieme }
            };

            AfficherDico(dictionnaire);

            Console.WriteLine("-------------------");

            dictionnaire.Remove('c');

            AfficherDico(dictionnaire);


            Console.ReadLine(); 
        }

        public static void AfficherDico<C, S>(Dictionary<C, S> dictionnaire)
        {
            foreach(KeyValuePair<C,S> couple in dictionnaire)
            {
                Console.WriteLine(couple.Key + " : " + couple.Value);
            }
        }

    }
}
