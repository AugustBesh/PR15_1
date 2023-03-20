using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] flower = { "Анжелика", "Виктория",
            "Гагарин", "Катарина", "Юбилейная", "AveMaria"};
            
            string[] flower1 = {"Анжелика", "Виктория",
            "Гагарин", "Катарина", "Юбилейная",
                "Красная", "Чайная", "Принц"};
            string[] flower2 = { "Виктория",
            "Гагарин", "Катарина",  "Красная",
                "Чайная",  "BluSky"};
            string[] flower3 = {"Анжелика", "Виктория",
             "Юбилейная", "RedFair", "Чайная", "Принц"};
            Console.WriteLine("Сорта есть у каждого");
            Print_mnozh(flower1.Intersect(flower2).Intersect(flower3));
            Console.WriteLine("Сортов нет ни у кого");
            Print_mnozh(flower.Except(flower1).Except(flower2).Except(flower3));
            Console.WriteLine("Сорт есть хотя бы у одного");
            Print_mnozh(flower1.Union(flower2).Union(flower3).
                Except(flower1.Intersect(flower2).Intersect(flower3)));
            Console.ReadKey();

        }
        private static void Print_mnozh(IEnumerable<string> res)
        {
            foreach (string s in res)
                Console.WriteLine(s);
        }
    }
}
