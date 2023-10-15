using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Task 1");
            Console.Write("Enter an integer to tell you if it is an even or odd number :");
            int number = int.Parse(Console.ReadLine());
            if(number %2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number !\n");
            }
            else
            {
                Console.WriteLine($"The number {number} is an odd number !\n");
            }


            //Задание 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Hello Friend! Welcome to the \"21\" game!");
            Console.WriteLine("Enter the number of playing cards you have!");
            int cards = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i=1; i <= cards; i++)
            {
                Console.WriteLine($"Enter the playing card number : {i}");
                string cardValue = Console.ReadLine();
                switch(cardValue)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(cardValue); 
                        break;
                }
            }
            Console.WriteLine($"The sum of the cards in your hand is equal to : {sum}\n");


            //Задание 3
            Console.WriteLine("Task 3");
            Console.Write("Enter an integer to tell you if it is prime or not : ");
            int num = int.Parse(Console.ReadLine());
            
            if (num <= 1)
            {
                Console.WriteLine("The number is not prime!");
                Console.ReadKey();
                return;
            }
            bool isPrime = true;  
            int divisor = 2;

            while (divisor < num)
            {
                if (num % divisor == 0)
                {
                    isPrime = false;  
                    break;  
                }
                divisor++;
            }

            if (isPrime)
            {
                Console.WriteLine("The number is prime!\n");
            }
            else
            {
                Console.WriteLine("The number is not prime!\n");
            }


            //Задание 4
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter the number of digits to find the smallest number!");
            int total = int.Parse(Console.ReadLine());
            int smallestNumber = int.MaxValue;

            for (int i =1;  i <= total; i++)
            {
                Console.WriteLine($"Enter the number {i}");
                int numb = int.Parse(Console.ReadLine());
                
                if (numb < smallestNumber)
                {
                    smallestNumber = numb;
                }
            }
            Console.WriteLine($"The smallest number in the series is: {smallestNumber}\n");


            //Задание 5
            Console.WriteLine("Task 5");
            Console.WriteLine("Game \"Guess the number\" ! Enter the maximum range of numbers that the game should have!");
            int max = int.Parse(Console.ReadLine());

            Random gener = new Random();
            int robot = gener.Next(0, max+1);

            Console.WriteLine("Guess which number the robot chose?");
            
            while (true) {
                int numberUser = int.Parse(Console.ReadLine());
                if (numberUser > robot) {
                    Console.WriteLine("The number of the robot is lower !");
                }
              else if (numberUser < robot)
                {
                    Console.WriteLine("The robot number is higher !");
                }
                else
                {
                    Console.WriteLine("Congratulations, you guessed the number");
                    break;
                }
            }          
            Console.ReadKey();
        }
    }
}
