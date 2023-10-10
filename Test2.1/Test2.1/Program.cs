using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string fullName = "Ghinda Vadim";
            byte age = 23;
            string mail = "ghindavadim427@gmail.com";
            float programming = 9.55f;
            float math = 8.9f;
            float physic = 8.88f;
            Console.WriteLine($"Full name : {fullName, 27}");
            Console.WriteLine($"Age : {age, 33}");
            Console.WriteLine($"Email : {mail,31}");
            Console.WriteLine($"Programming : {programming,25}");
            Console.WriteLine($"Math : {math,32}");
            Console.WriteLine($"Physic : {physic,30}\n");

            // Задание 2
            float totalScore = programming + math + physic;
            float averageScore = totalScore / 3;
            Console.WriteLine($"Total score : {totalScore,25:0.00}");
            Console.WriteLine($"Average score : {averageScore,23:0.00}");
            Console.ReadKey();
        }
    }
}
