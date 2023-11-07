// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

namespace Lekcja1
{
    class Program 
    {
        static void Main(string[] args) 
        {
            var name = "Ewa";
            var sex = "kobieta";
            var age = 33;

            if (sex == "kobieta" && age < 30)
            {
                Console.WriteLine("kobieta poniżej 30 lat");
            }
            else if (sex != "kobieta" && age < 18)
            {
                Console.WriteLine("niepełnoletni mężczyzna");
            }
            else if (sex == "kobieta" && age > 10 && age < 20)
            {
                Console.WriteLine("nastolatka");
            }
            else if (name == "Ewa" && age == 33)
            {
                Console.WriteLine("Ewa, lat 33");
            }
        
 
        }

    }







}