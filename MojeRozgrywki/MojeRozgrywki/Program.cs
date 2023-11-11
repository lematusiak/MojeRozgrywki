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
                // OPERATORY LOGICZNE

                // Zmienna bool określa prawdę lub fałsz (true or false)
                // bool a = 2 < 1; False  // bool a = 2 >1 True

                // operator jednoargumentowy  - tzw negacja ponieważ określa jedno działanie, jedną liczbę
                // liczbę, wartość - jak powyżej jedno true
                // bool a = true; (daje true) bool a = !true (daje fals)

                // w c# znak = to przypisanie, == jest równy
                //
                // ZAIMPLEMENTOWANIE - oznacza, że kod programu został napisany
                // i dostosoway do wykonania określonego zadania lub funkcji
                //
                // 1) KONIUNKCJA LOGICZNA &&  (i AND) czyli oba warunki muszą być spełnione
                // bool a = 1 == 1 && 1 != 1; // wyskoczy false
                // 2) ALTERNATYWA || (lub OR) tylko jeden spełniony wystarczy do prawdy true
                // bool a = 1 == 1 || 1 != 1; // wyskoczy prawda

                // KOLEJNOŚĆ WYKONYWANIA DZIAŁAŃ LOGICZNYCH
                // Koniunkcja && wiąże MOCNIEJ niż Alternatywa
                // bool a = true || true && false; // czyli tutaj prawda i fałsz jednocześnie daje fałsz - czyli alternatywa da true finalnie (bo prawda || fałsz - jeden warunek spełniony) 
                // bool a = (true || true) && false; // dwie prawdy to również prawda ale z && false dają finalnie false

                // DLA WARTOŚCI BEZWZGLĘDNYCH NIE MA PRZEWIDZIANYCH OSOBNYCH OPERATORÓW
                // FUNKCJE METODY

                Math.Pow(2,3); // Potęgownaie 2 do 3 = 8 finalnie daje 8
                               // Console.WriteLine(Math.Pow(2,3));
                Math.Sqrt(9);  // Pierwiastek finalnie daje 3
                               // Console.WriteLine(Math.Sqrt(9));
                Math.Abs(5);   // wartość bezwzględna zarówno z 5 i -5 daje 5
                Console.WriteLine((5)); 

            
                Console.ReadKey();
                // Podsumowując: do potęgowania, pierwiastkowania, itd nie mamy osobnych operatorów

            }
        
 
        }

    }







}