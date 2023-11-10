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
                // PRZYPISYWANIE WARTOŚCI, ZMIENNA STAŁA, DZIAŁANIA +-:,
                // INKREMENTACJA, DEKREMENTACJA, OPERATORY MATEMATYCZNE


                // PIERWSZY SPOSÓB

                // string zmienna;       // deklaracja zmiennej tekstowej
                // zmienna = "Lemalia";  // przypisanie wartości

                // DRUGI SPOSÓB

                // można od razu zadeklarować zmienną i przypisać jej wartość
                // do zmiennej stałej musimy przypisać od razu wartość
                // zmienna const musi mieć określoną wartość - bo jest stałą


                // const string stała = "Maraba";


                // Console.WriteLine(zmienna); // wyskoczy - Lemalia
                // Console.WriteLine(stała); // wyskoczy - Maraba
                // Console.ReadKey();

                int a = 2;
                int b = 3;
                int c1;
                int c2;
                int c3;
                int c4;
                int c5;
                int c6;
                int c7;

                // a = a + 1; // powiększenie wartości a o 1 (razem 3)
                // a += 1;    // powiększenie zapisane inaczej, wynik w wartości 1
                // a++;       // INKREMENTACJA (zwiększ o 1), powiększenie zapisane inaczej
                // a--;       // DEKREMENTACJA (zmniejsz o 1), wynik 1



                // c1 = a + b;    // dodawanie 5
                // a += b;        // dodawanie a+b ale wynik zostawiamy w zmiennej a zamiast c1

                // c2 = a - b;    // odejmowanie -1
                // a -= b;        // odejmowanie a-b, wynik w zmiennej a

                // c3 = a * b;    // mnożenie 6
                // a *= b;        // możenie a*b, wynik w zmiennej a

                // c4 = b / a;   // dzielenie 1  (3:2, w trójce mamy jedną liczbę całkowitą dwójkę int, bez pozostałej reszty)
                // b /= a;       // dzielenie b/a, wynik w zmiennej b

                // c5 = a/b;     // dzielenie 0 (2:3, dwójka jest za mała, żeby było w niej choć jedno int 3, więc wynik zero)
                // a /= b;       // dzielenie a/b, wynik w zmiennej a  

                // c6 = b % a;    // reszta z dzielenia 3:2 pozostaje 1
                // b %= a;        // reszta z dzielenia 3:2, wynik w zmiennej b

                // c7 = a % b;    // reszta z dzielenia 2:3 2 jest za małe zmieścić 3, pozostaje 2)
                // a %= b;        // reszta z dzielenia 2:3, wynik w zmiennej a


                Console.WriteLine(a);
                Console.ReadKey();









            }
        
 
        }

    }







}