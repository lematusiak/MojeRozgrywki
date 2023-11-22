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

                // RZUTOWANIE ZMIENNYCH

                /*
                 * Rzutowanie zmiennych to proces konwersji wartości jednego typu danych na inny, 
                 * kompatybilny typ danych. W programowaniu, rzutowanie jest używane w celu zmiany
                 * typu danych zmiennej, na przykład zamiany liczby całkowitej na liczbę zmiennoprzecinkową. 
                 */

                // W poniższym  int MaxValue to: +- 2 147 483 647 short MaxValue 32 767

                // int i = int.MaxValue;
                // short s = short.MaxValue;

               // i = s;   
               
                        // do dużej butli i - wlewamy małą s
                        // do  i inta przypisujemy wartość jaka siedzi w s shorcie
                        // 2 147 483 647 zmieści 32 767 więc działanie dobre 
                        // inaczej; int dużo większy od shorta, więc go zmieści

               // Console.WriteLine(i);  
                                       // wyświetli się 32 767
                                       // pod zmienną typu int przechowujemy więc
                                       // max wartość short, bo więcej się nie da
                                       // w praktyce: Do wielkiej bańki możemy nalać tylko tyle wody
                                       // ile jest w małej bańce... Działanie jest wtedy prawidłowe,
                                       // nie potrzebujemy wykonywać rzutowania (zamiany zmiennych)

                // s = i;  
                // do małej butli s chcemy wlać dużą i
                // jeśli tak to tłumaczymy znika odczucie,
                // że jest to zapisywane jakby odwrotnie

                // gdybyśmy chcieli zrobić takie działanie, wyświetli nam się
                // "Nie można niejawnie przekonwertować typu int na short.
                // Isnieje konwersja jawna (czy nie brakuje rzutu?)
                // Inaczej: program nie dopuszcza konwersji niejawnej, jeżeli istnieje
                // możliwość utraty jakichś informacji
                // W PRAKTYCE: jeśli byśmy chcieli przelać wodę z dużej bańki do małej,
                // pewna woda by się przelała (utracilibyśmy dane, informacje)

                // rzut, konwersja jawna i niejawna

                /*  Słowa: "BRAKUJE RZUTU"
                 *  Brak rzutu w programowaniu oznacza, że nie można automatycznie 
                 *  przekonwertować jednego typu danych na inny. Wyobraża to 
                 *  próbę zmieszczenia kwadratu w okrągu; 
                 *  nieprawidłowe typy danych mogą spowodować błąd 
                 *  lub niepożądane zachowanie programu. 
                 *  Na przykład, jeśli spróbujesz przypisać wartość zmiennej typu int 
                 *  do zmiennej typu string BEZ RZUTOWANIA, może wystąpić błąd, 
                 *  ponieważ int i string to różne typy danych. 
                 *  
                 *  KONWERSJA JAWNA I NIEJAWNA:
                 *  
                 *  KONWERSJA JAWNA to proces, w którym możemy bezpiecznie 
                 *  przekonwertować typy danych z mniejszych na typy większe. 
                 *  (zawartość mniejszej butli wlana do większej)
                 *  Na przykład, przekonwertowanie liczby całkowitej na liczbę 
                 *  zmiennoprzecinkową jest konwersją jawną, ponieważ nie tracimy żadnych danych.
                 *  
                 *  KONWERSJA NIEJAWNA, ma miejsce, gdy możemy przekonwertować 
                 *  typy danych większe na typy mniejsze. 
                 *  Na przykład, przekonwertowanie liczby zmiennoprzecinkowej na liczby całkowite 
                 *  jest konwersją niejawna, ponieważ możemy stracić część informacji po przecinku.
                 *  (wlewamy z większej butli do mniejszej, będąc świadomym utraty części wody)
                 *  
                 *  KLUCZ DO RZUTOWANIA POPRZEZ KONWERSJĘ NIEJAWNĄ
                 */

                // s = (short)i;

                // Console.WriteLine(i);

                // wyświetli się 2 147 483 647 - bo zrobiliśmy 
                // rzutowanie jawne, czyli jakby będac świadomym utraty danych
                // do zmiennej typu short zostaje przypisana zmienna typu int
                // ale wyświetlona liczba dotyczy zmiennej i


                // Co innego gdybyśmy chcieli wyświetlić przez cw nie i, ale s
                
                // Console.WriteLine(s); 
                
                     // to wyświetli się się -1 bo pętla się zapętli
                     // w "s" i tak nie pomieszczą się inty
                     // czyli rzutowanie zostanie wykonane,
                     // ale i tak pętla się zapętli, dlatego otrzymamy "kosmiczne" -1
                     // bo nie była w stanie pomieścić tak dużej liczby intów                
                
                // INNY PRZYKŁAD:

                int i = int.MaxValue;
                double d = 5.1;   // double - zmiennoprzecinkowa, zmienna przechowuje ułamki

                i = (int)d; // tutaj rzutujemy zmienną d na typu int

                Console.WriteLine( i );

                // CIEKAWOSTKA: wyświetli się 5, a nie 5.1 bo int nie przechowuje 
                // wartości ułamkowych
                // Czyli przerzutowaliśmy zmienną d na inta, 
                // ale to wiązało się ze zgubieniem jednej dziesiątej piątki
                // W incie pozostają tylko całości

                // PAMIĘTAJ:
                // Rzutowanie musi być JAWNE, musimy to zadeklarować
                // i wtedy możemy stracić część informacji. 
                //    Możemy stracić ale nie musimy. To zależy, bo gdyby zmienna typu
                // double była równa 5 to przechowamy całą informację
                 
                // 16.00 Wczytywanie danych z konsoli


                Console.ReadKey();

}

}

}







}