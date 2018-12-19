using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecrivez votre âge svp");
            int age = int.Parse(Console.ReadLine());//int.Parse converti string en int
            if (age >= 18 && age <=120)//vérification que l'age est bien supérieur ou égal à 18 ans et ne dépasse 10 ans
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc majeur.");
            }
            else if (age < 18 && age > 0)// Vérification que l'age est bien compris entre 0 et 18 ans
            {
                Console.WriteLine($"Vous avez {age} ans, vous êtes donc mineur.");
            }
            else
            {
                Console.WriteLine("Oops, il doit y avoir une erreur");
            }
        }
    }
}
