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
                // Kurs 40, Lekcja 4, Pętle While, For, Do While
                // 
                // PĘTLA WHILE (tłumaczone na dopóki, aż)
                //
                // Pętla While działa tak długo, aż warunek zostanie spełniony
                // Działa dopóty, dopóki zostanie spełniony
                // While true - to jest inaczej warunek kontynuacji pętli


                // Pozwala ona na wielokrotne wykonywanie określonego bloku kodu,
                // dopóki warunek nie zostanie spełniony.
                // Jest to przydatne, gdy potrzebujemy wykonać pewną czynność wielokrotnie,
                // ale nie znamy dokładnej liczby powtórzeń z góry.
                // Poniżej przykład pętli nieskończonej:

                //while (true) 
                // {
                //    Console.WriteLine( "Tekst");
                // }

                // int a = 0;

                // while (a < 3) // dobrze skonstruowany warunek
                //{
                //   Console.WriteLine(a);
                //    Console.WriteLine("Tekst");
                //    a++;       // operacja wewnątrz ciała pętli // uwaga na a--; poniżej mowa
                //}

                // Uwaga: wyświetli się 0 Tekst, 1 Tekst, 2 Tekst
                // Ale gdyby był warunek wewnątrz pętli a--; 
                // pętla działała by do nieskończoności
                // możnaby wyjść z tej pętli tzw instrukcją skoku, ale to nie dzisiaj
                // instrukcja skoku przydaje się do gier, gdzie pewien level po prostu 
                // trzeba zakończyć


                // Console.WriteLine(a); 

                // Jeśli byśmy dopisali kolejne Console.WriteLine (a) - jak powyżej -  to a++
                // została wykonana i gdy warunek został sprawdzony i okazał się fałszywy
                // to ta wartość zostaje ponieważ jest fałszywa. Wyświeli się do 
                // 0 Tekst, 1 Tekst, 2 Tekst, 3 - i tak pozostanie

                // Uwaga: wyświetli się 0 Tekst, 1 Tekst, 2 Tekst
                // Ale gdyby był warunek wewnątrz pętli a--; 
                // pętla działała by do nieskończoności
                // możnaby wyjść z tej pętli tzw instrukcją skoku, ale to nie dzisiaj
                // instrukcja skoku przydaje się do gier, gdzie pewien level po prostu 
                // trzeba zakończyć

                // 11.22

                // PĘTLA FOR
                // Niewypełniona pętla for podobnie będzie sprawdzać program w nieskończoność
                // Wyświetli się tutaj: 0 Tekst, 1 Tekst; 2 Tekst; 3 Tekst; 4 Tekst 



                // for ( int b = 0; b < 5; b++ )
                // {
                //     Console.WriteLine(b);
                //    Console.WriteLine("Tekst");
                // }

                // Ważne, tutaj program będzie działał tylko do zamknięcia klamry pętli.
                // W pętli while, działał też poza wyświetlenie klamry 

                // Console.WriteLine(b);

                // Więc w while program rozpatrzyłby powyższe cw, i wyświetlił 5
                // W zmiennej for wystąpi błąd i program, co wykaże program
                // Wyświetli się builed failed - budowa nieudana 
                // Druga przestrzeń jest warunkiem kontynuacji, a nie przerwania - jeśli jest prawdziwa

                // Ciekawostka taka:
                // Jeśli b wyrzucimy poza pętle for - wtedy nie wyświetli się 
                // budowa nieudana, tylko podobnie jak w while wyświetli się 5
                // Wszytko dlatego, że b jest zadeklarowane przed pętlą
                // Pętla for nie wymaga wszystkich danych w nawiasie
                // Każda z tych przestrzeni jest opcjonalna /możer być a nie musi/
                // Na przykład mogą te dane być przed pętlą

                // int b = 0;

                // for (  ; b < 5; b++)
                //{
                //    Console.WriteLine(b);
                //    Console.WriteLine("Tekst");
                //}

                //Console.WriteLine(b); // teraz wyświetli się 5


                // PĘTLA DO WHILE
                // Najbardziej różni się od while i for, ponieważ wcześniejsze dwie działają
                // na podobnej zasadzie, ale inaczej się je deklaruje i pisze
                // Podobnie jak wcześniej jest pętlą nieskończoną
                // Oto przykład gdy Tekst ciągle (nieskończenie) będzie się wyświetlał:

                // do
                //{
                //   Console.WriteLine(  "Tekst");
                //} while (true);

                // Ale inna ciekawostka:
                // Pętla do while przestanie działać gdy pod while będzie warunek false
                // Ale ma zagwarantowane, że w klamrze wykona się jeden raz tekst
                // pomimo tego, że warunek jest fałszywy
                // bo najpierw cw wypisze Tekst, a dopiero później sprawdzi true lub false
                // To przyda się, gdy menu będzie widoczne raz / podczas jakiegoś programu /
                // ale ponownie już się nie wyświetli, gdy użytkownik np zamknie program

                //     do
                // {
                //     Console.WriteLine("Tekst");
                // }
                // while (false);

                // TEORIA:

                // Pętla do while to konstrukcja w języku C#, która umożliwia powtarzanie określonych czynności,
                // dopóki warunek jest spełniony.
                // Można to porównać do sytuacji, gdy wykonujesz określone zadanie tak długo,
                // jak długo spełniony jest pewien warunek
                // Na przykład, gdybyśmy tworzyli program, który ma pytać użytkownika o wprowadzenie hasła,
                // ale dopóki nie zostanie wprowadzone poprawne hasło, będzie to powtarzać, możemy użyć pętli do while.
                // Kod może wyglądać tak:

                // PRZYKŁAD:

                // string haslo;
                //do
                //{
                //    Console.WriteLine("Proszę wprowadzić hasło:");
                //    haslo = Console.ReadLine();
                //} while (haslo != "poprawnehaslo");

                // Uwaga: poniższa pętla będzie pytała o hasło, dopóty
                // dopóki takiego nie podamy
                // po wpisaniu poprawnehaslo - pętla ZATRZYMA się, bo osiagnie cel



                Console.ReadKey();
            }
      
        }

    }







}