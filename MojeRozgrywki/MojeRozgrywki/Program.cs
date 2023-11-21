// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace Lekcja5
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // Kurs 051, Lekcja 5, Konwersja typów, rzutowanie, komentarze

                // if, else if, else

                bool isMan = true;
                var age = 20;
                string name = "Pawel";

                if (isMan && age == 20)
                {
                    Console.WriteLine("mężczyzna w wieku 20 lat");
                }
                else if (name == "Pawel" && age > 50)
                {
                    Console.WriteLine("Pawel po pięćdziesiątce");
                }
                else if ((isMan == false || isMan)   && age < 18)
                {
                    Console.WriteLine("niepełnoletnia osoba");
                }
                else
                {
                    Console.WriteLine("ktoś inny");
                }


                       

               Console.ReadKey();
            }

        }

    }







}