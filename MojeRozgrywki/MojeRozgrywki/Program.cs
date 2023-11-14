 // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.ComponentModel.Design;
using System.Threading.Tasks.Sources;

namespace Lekcja2
{
    class Program 
    {
        static void Main(string[] args) 
        {

            {
                // Zwracać typ danych oznacza, że funkcja, metoda lub wyrażenie zwraca wynik.
                // To tak jak zamawiasz coś w restauracji, zwrócone jest danie.


                // If bez żadnych klamr sprawdza tylko jedną instrukcję
                // Sprawdza ją do najbliższego średnika;
                // Pozostałe będą się wyświetlać, bez względu czy są prawdziwe
                // Poniżej wyświetlą się 2x warunki prawdziwe, bo bool jest fałszywy
                // int a = -1;
                // bool b = a > 0;
                // if (b) 
                // Console.WriteLine("Warunek Prawdziwy");
                // Console.WriteLine("Warunek Prawdziwy");
                // Console.WriteLine("Warunek Prawdziwy");

                // W klamrach zostaną sprawdzone wszystkie 3 warunki.
                // Każdy warunek zostanie sprawdzony
                // W przypadku prawdy wyświetli się 3 x Warunek Prawdziwy
                // W przypadku fałszu nie wyświetli się nic
                // int a = 1;
                // bool b = a > 0;
                // if (b)
                // {
                //   Console.WriteLine ("Warunek Prawdziwy");
                //   Console.WriteLine ("Warunek Prawdziwy");
                //   Console.WriteLine ("Warunek Prawdziwy");
                // }

                // int a = -1;
                // bool b = a > 0;
                // if (b)
                // {
                //    Console.WriteLine("Warunek Prawdziwy");
                //    Console.WriteLine("Warunek Prawdziwy");
                //    Console.WriteLine("Warunek Prawdziwy");
                // }
                // Dla przykładu można zastosować 2 ify

                // int a = -1;

                // if (a > 0) 
                // {
                //    Console.WriteLine("Mocne A" );
                // }
                // if (a < 0)
                // {
                //    Console.WriteLine("Słabitkie A");
                // }

                // Jeśli 1-szy if zostanie spełniony wyświetli się tylko pierwszy if, bez drugiego obojętnie na wynik
                // Jeśli 1- szy if nie zostanie spełniony, rozpatrzony będzie 2-gi if

                //int a = 1;

                //if (a != 1)
                //{
                //    Console.WriteLine( "nieprawda");
                //}
                //else
                //{
                //    Console.WriteLine("obojętnie czy prawda czy nie - wyświeli się");
                //

                // Else zawsze się wykonuje, gdy if nie został spełniony
                // Tłumaczy się go jako - w przeciwnym wypadku

                int a = 0;
                if (a > 0)
                {
                    Console.WriteLine( "blisko");
                }
                else if (a == 0 && a !=1) // else if to inaczej dodatkowy if
                {
                    Console.WriteLine("w punkt");
                    Console.WriteLine("i na pewno to nie jest jeden");
                }
                else
                {
                    Console.WriteLine("też bliko, ale jednak nie");
                }
                // W tym przypadku, będzie rozpatrzony if, póżniej else if 
                // Ponieważ else if jest prawdziwy, program na tym pozostanie
                // Gdyby nie drugi if również nie był prawdziwy, bez względu na wynik wyświetli się else 
                // Krótko mówiąc: jeden spełniony if lub if else zamyka sprawę
                // Przy dwóch warunkach spełnionych, gdy w dwóch klamrach zrobimy 
                // console - wyświetlą się nam obie

                // if, else if i else zamyka całe działanie
                // kolejny if po else otwiera nastepne 

                if (a != 2)
                {
                    Console.WriteLine( "też prawda");
                }
                else
                {
                    Console.WriteLine(  "co, nie?");
                }
                Console.ReadKey();
            }
        // Wyświetli się - w punkt - i na pewno to nie jest jeden - też prawda
        // Console.ReadKey(); ZAWSZE umieszczamy na KOŃCU wszelkich działań
        }

    }







}