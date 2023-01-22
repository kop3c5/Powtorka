using System;
using System.Collections.Generic;

namespace Powtorka
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pierwszy program -rozgrzewka

            /*Zadanie 1

            Stwórz nowy projekt typu Console App(.Net Core). */

            /*Zadanie 2

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name); */

            /*Zadanie 3

            W metodzie Main umieść następujący kod:

            int result = 5 + 9

            Uruchom projekt.
            Jeśli uruchomienie zakończy się niepowodzeniem, znajdź i napraw błąd. Błędy możesz zobaczyć w oknie Error List. */

            //int result = 5 + 9;   //trzeba było dodać średnik

            /*  Operatory
            Zadanie 1
            1. w metodzie main utwórz 6 zmiennych.
            2. każda zmienna powinna przechowywać odpowiednio dobrany przez ciebie typ danych na podstawie opisu.
            3. wartości mogą być dowolne. */

            ////zmienna o nazwie number przechowująca liczbę całkowitą.

            //int number = 5;

            ////zmienna o nazwie money przechowująca liczbę zmiennoprzecinkową(float).

            //float money = 33.25f;

            ////zmienna o nazwie text przechowująca tekst.

            //string text = "kaźmisz";

            ////zmienna o nazwie islogged przechowująca wartość logiczną.

            //bool islogged = true;

            ////zmienna o nazwie mychar przechowująca pojedynczy znak.

            //char mychar = 'z';

            ////zmienna o nazwie price przechowująca liczbę zmiennoprzecinkową z największą precyzją(decimal).

            ////decimal price = 1.878579157;

            ////po deklaracji wszystkich zmiennych wyświetl je w konsoli.

            //console.writeline(number);
            //console.writeline(money);
            //console.writeline(text);
            //console.writeline(islogged);
            //console.writeline(mychar);

            //Zadanie 2

            //Utwórz zmienną o nazwie myAge typu string z wartością Age: .
            //Utwórz zmienną o nazwie wifeAge typu int z wartością 18.
            //Utwórz zmienną o nazwie result i przypisz do niej rezultat dodawania zmiennych myAge i wifeAge.
            //Wyświetl zmienną result w konsoli.
            //Jakie wnioski?

            //string myAge = "Age:";
            //int wifeAge = 18;
            //string result = myAge + wifeAge;
            //Console.WriteLine(result);

            //Nastąpiła automatyczna konwersja na typ znakowy - string

            //Zadanie 3

            //Utwórz 3 zmienne typu bool o następujących nazwach i wartościach:
            //isTrue o wartości true.
            //isFalse o wartości false.
            //isReallyTrue o wartości true.
            //Utwórz 3 kolejne zmienne o następujących nazwach i przypisz do nich wyniki działań na zmiennych logicznych:
            //and powinna zwierać wynik działania isTrue AND isFalse.
            //or powinna zwierać wynik działania isTrue OR isReallyTrue.
            //negative powinna zawierać wynik negacji isFalse.
            //Wyświetl zmienne and, or i negative w konsoli.

            //bool isTrue = true;
            //bool isFalse = false;
            //bool isReallyTrue = true;
            //string and = (isTrue & isFalse).ToString();
            //string or = (isTrue | isReallyTrue).ToString();
            //string negative = (!isFalse).ToString();
            //Console.WriteLine(and);
            //Console.WriteLine(or);
            //Console.WriteLine(negative);

            //Zadanie 4

            //Utwórz dwie zmienne o nazwach a, b i przypisz do nich wartości 5, 12.
            //Utwórz zmienne o nazwach add, sub, div, mul, mod i przypisz do nich kolejno wynik dodawania, odejmowania, dzielenia, mnożenia i modulo zmiennych a i b.
            //Wyświetl zmienne add, sub, div, mul, mod w konsoli.

            //int a = 5;
            //int b = 12;
            //int add = a + b;
            //int sub = a - b;
            //float div = a / b;
            //int mul = a * b;
            //float mod = b % a;
            //Console.WriteLine(add);
            //Console.WriteLine(sub);
            //Console.WriteLine(div);
            //Console.WriteLine(mul);
            //Console.WriteLine(mod);

            //Zadanie 5

            //twórz trzy zmienne typu string o nazwach a, b i c.
            //Do zmiennych przypisz kolejno tekst Ala, ma, kota..Utwórz 4 zmienną o nazwie result i przypisz do niej wynik operacji a + b + c.
            //Wyświetl zmienną result w konsoli.
            //Napisz w komentarzu swoje spostrzeżenia dotyczące wyniku.


            //string a = "Ala ";
            //string b = "ma ";
            //string c = "kota.";
            //string result = a + b + c;
            //Console.WriteLine(result);

            //operator dodawania może łączyć także ciągi znaków

            //Instrukcje sterujące i pętle

            //Zadanie 1

            //Utwórz dwie zmienne typu int o nazwach n1 i n2. Przypisz do nich liczby 10 i 20.
            //Używając instrukcji if sprawdź wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa lub czy są równe.
            //Tekst powinien się wyświetlić według wzoru n1 jest większe od n2 lub n1 jest równe n2.

            //int n1 = 10;
            //int n2 = 20;
            //if (n1 > n2)
            //{
            //    Console.WriteLine("n1 jest większe od n2");
            //}
            //else if (n2 > n1)
            //{
            //    Console.WriteLine("n2 jest większe od n1");
            //}
            //else
            //{
            //    Console.WriteLine("n1 jest równe n2"); 
            //}

            //Zadanie 2

            //Stwórz pętlę, która 10 razy wypisze w konsoli C#.
            //Zadanie rozwiąż używając pętli for oraz pętli while.
            //W sumie w konsoli wyraz C# powinien pojawić się 20 razy.

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("C#");
            //}
            //int y = 0;
            //while (y<10)
            //{
            //    Console.WriteLine("C#");
            //    y++;
            //}

            //Zadanie 3

            //Stwórz zmienną o nazwie n, które będzie zainicjowana wartością 10.
            //Następnie wypisz w konsoli informacje czy liczba jest parzysta, czy nie, dla liczb od 0 do n.Wzór:

            //int n = 101;
            //string wynik = ((n % 2) == 0) ? "parzysta" : "nieparzysta";
            //Console.WriteLine(wynik);

            //Zadanie 4 * dodatkowe
            //Stwórz zmienną o nazwie n, która będzie zawierała wartość 5.
            //Następnie napisz skrypt, który wypisze w konsoli poniższy schemat.
            //Schemat dla n = 5.

            //*
            //**
            //***
            //****
            //*****

            //int n = 5;
            //string gwiazdka = "*";
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(gwiazdka);
            //    gwiazdka += "*";
            //}

            //dla wariantu n=3, należy zmienić zadeklarowaną wartość n na 3

            //Zadanie 5 * dodatkowe
            //Utwórz zmienną exam, która będzie zawierała wartość od 0 do 100.
            //Zmienna exam przechowuje wyniki egzaminu.
            //Utwórz kod, który wyświetli w konsoli ocenę z testu na podstawie zmiennej point, według poniższego schematu.
            //0 - 39 pkt - Ocena Niedostateczna
            //40 - 54 pkt - Ocena Dopuszczająca
            //55 - 69 pkt - Ocena Dostateczna
            //70 - 84 pkt - Ocena Dobra
            //85 - 98 pkt - Ocena Bardzo Dobra
            //99 - 100 pkt - Ocena Celująca
            //W przypadku gdy wartość exam jest mniejsza od 0 lub większa od 100 wyświetl komunikat: Wartość poza zakresem.
            //Przykład: Dla point z wartością 57, w konsoli powinno wyświetlić się Ocena Dostateczna.

            // !!! z tego co rozumiem to w poleceniu jest błąd, ponieważ tak czy inaczej analizujemy jedną zmienną point lub exam
            //int exam = 57;

            //if (exam >= 0 && exam <= 39)
            //{
            //    Console.WriteLine("Ocena Niedostateczna");
            //}
            //else if (exam >= 40 && exam <= 54)
            //{
            //    Console.WriteLine("Ocena Dopuszczająca");
            //}
            //else if (exam >= 55 && exam <= 69)
            //{
            //    Console.WriteLine("Ocena Dostateczna");
            //}
            //else if (exam >= 70 && exam <= 84)
            //{
            //    Console.WriteLine("Ocena Dobra");
            //}
            //else if (exam >= 85 && exam <= 98)
            //{
            //    Console.WriteLine("Ocena Bardzo Dobra");
            //}
            //else if (exam >= 99 && exam <= 100)
            //{
            //    Console.WriteLine("Ocena Celująca");
            //}
            //else
            //{
            //    Console.WriteLine("Wartość poza zakresem");
            //}

            //Kolekcje

            //Zadanie 1

            //Utwórz czteroelementową tablicę typu string o nazwie colors.
            //Tablicę uzupełnij dowolnymi nazwami kolorów.
            //Wyświetl pierwszy kolor z tablicy w konsoli według wzoru Mój pierwszy kolor to: niebieski.
            //Wyświetl ostatni kolor z tablicy w konsoli według wzoru Mój ostatni kolor to: czerwony.

            //string[] colors = { "niebieski", "zielony", "żółty", "czerwony" };

            //Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
            //Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}");

            //Zadanie 2
            //Stwórz tablicę z 10 dowolnymi liczbami.
            //Następnie wypisz w konsoli, przy użyciu pętli for, foreach i while 10 razy tekst Liczba: 13, gdzie 13 będzie kolejną liczbą z tablicy.
            //Wzór

            //Liczba: 0
            //Liczba: 1

            //int[] tab = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Liczba: " + tab[i]);
            //}
            //Console.WriteLine("");
            //foreach (int number in tab)
            //{
            //    Console.WriteLine("Liczba: " + number);
            //}
            //Console.WriteLine("");
            //int j = 0;
            //while (j < 10)
            //{
            //    Console.WriteLine("Liczba: " + tab[j]);
            //    j++;
            //}

            //Zadanie 3

            //Utwórz czteroelementową listę List<string> o nazwie fruits.
            //Tablicę uzupełnij dowolnymi nazwami owoców, używając metody remove.
            //Wyświetl w konsoli wszystkie owoce według wzoru Pomidor, Jabłko, Marchewka. Między nazwami owoców musi się znaleźć przecinek i spacja.
            //Usuń za pomocą metod Revome i RemoveAt pierwszy i ostatni element listy.
            //Wyświetl wszystkie elementy listy.

            //var fruits = new List<string> { "Kalafior", "Zimnioczek", "Sałata" };

            //foreach (string fruit in fruits)
            //{
            //    Console.Write(fruit + ", ");
            //}

            //fruits.Remove(fruits[0]);
            //fruits.RemoveAt(fruits.Count - 1);
            //Console.WriteLine("\nLista po usunięciu elementów:");
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
        }
    }
}
