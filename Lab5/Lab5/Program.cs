using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Program
    {
        static int Suma(int a, int b)
            => a + b;

        delegate int delegat2Int(int a, int b);

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(){ Year=1990, FName="Jan", LName="Kowalski"},
                new Person(){ Year=1985, FName="Janusz", LName="Pudzian"},
                new Person(){ Year=1996, FName="Damian", LName="Nowak"},
                new Person(){ Year=1999, FName="Konrad", LName="Nowakowski"},
            };

            List<int> numbers = new List<int>() { 1, 7, 5, 2, 150, 10 };
            List<int> numbers2 = new List<int>() { 5, 2, 1, 15, 24, 9 };
            

            int Wynik1 = Suma(3, 100);

            delegat2Int delegat1 = Suma;

            int Wynik2 = delegat1(3, 100);

            delegat2Int delegatlambda = (a, b) => a + b;
            int wynik3 = delegatlambda(3, 100);

            IEnumerable<int> even_list = from el in numbers where el % 2 == 0 select el;

            foreach (int el in even_list)
            {
                Console.WriteLine($"Even: {el} ");
            }


            IEnumerable<int> minimum_list = from el in even_list orderby el ascending select el;

            Console.WriteLine($"Min: {minimum_list.First()}");

            IEnumerable<int> given_list = from el in numbers where el > 5 && el < 100 select el;

            foreach (int el in given_list)
            {
                Console.WriteLine($"Given: {el} ");
            }

            IEnumerable<Person> year_list = from el in people where el.Year > 1995 select el;

            foreach (Person el in year_list)
            {
                Console.WriteLine($"Po 1995: Imie={el.FName}, Nazwisko={el.LName}");
            }

            var name_list = from el in people where el.FName.StartsWith("Ja") orderby el.LName select el;

            foreach (Person el in name_list)
            {
                Console.WriteLine($"Ja: Imie={el.FName}, Nazwisko={el.LName}");
            }

            int num = (from s in people where s.FName.StartsWith("Ja") select s).Count();
            Console.WriteLine($"People with 'Ja': {num}");

            static List<List<int>> join_list(List<int> first, List<int> second)
            {
                List<List<int>> connection_result = new List<List<int>>() { first.Concat(second).ToList() };

                return connection_result;
            }

            foreach(List<int> list_result in join_list(numbers, numbers2))
            {
                foreach(int result in list_result)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
