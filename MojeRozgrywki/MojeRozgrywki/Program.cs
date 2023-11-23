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
                // Kurs 052, Lekcja 5, WCZYTYWANIE DANYCH Z KONSOLI

                /*
                 * Console.ReadKey(); - jest wczytywaniem danych z konsoli
                 * Console.ReadLine(); jest drugą metodą wczytywania z konsoli
                 * 
                 * Wpisujemy całą linię do Console.ReadLine(); i enterem wysyłamy do kompa
                 * Jednak się nie zapisała, gdyż nie mamy takiego przypisania               
                 * Console.RL jest zmienną typu string
                */

                // PIERWSZY SPOSÓB WCZYTYWANIA Z KONSOLI
                
                // string s = Console.ReadLine();
                // Console.WriteLine(s);

                // na konsoli nic się nie wyświetli. ale jesli wpiszemy "ala ma kota"
                // i przyenterujemy - PONOWNIE - wyświetli się "ala ma kota"
                // Żeby nie było - na tą chwilę jeszcze nie wiem z czym to się je -
                // Ale pewnie o tym się jeszcze przekonamy. Wytrwałości! 

                // DRUGI SPOSÓB WCZYTYWANIA Z KONSOLI

                if (Console.ReadKey().Key == ConsoleKey.D1)
                    Console.WriteLine("PRAWDA");


                // Sprawdzamy jaki został wciśnięty klawisz?
                // D1 jest to /jedynka (1)/ na klawiaturze numerycznej.
                // Tutaj skorzystamy z instrukcji warunkowej IF
                // Chodzi o to, że jeżeli naciśniemy ten klawisz "jedynki"
                // wyświetli się nam "PRAWDA". Jeśli nie, nie wyświetli się nic.
                // Bo przecież ta instrukcja na tym polega, żeby sprawdzić czy 
                // coś jest prawdą czy nie
                // Jeśli byśmy mieli napisane:
                // if (Console.ReadKey() == ConsoleKey.D1) to mielibyśmy info,
                // że nie da się porównać ConsoleReadKey z Console.Key
                // dopiero gdy właczyliśmy pole Key, program mógłbyć uruchomiony
                // jak powyżej we wzorze.

                // REASUMUJĄC; jeśli teraz wpiszesz 1 na klawiaturze, wypisz "PRAWDA"
                // na konsoli. W przeciwnym wypadku  - nie rób nic.
                // Na tym polega sens dzaiłania ifa

                // klikając 1 - wyświetli się 1PRAWDA
                // klikając każdy inny przycisk, będzie tylko to wyświetlone, 
                // co kliknęliśmy
                // Bez enetera się wyświetli, lub nie. Enter spowoduje, że zamknie się konsolapv


                Console.ReadKey();



}

}

}







}