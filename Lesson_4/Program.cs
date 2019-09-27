using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int userNumber;
            int userNumberSecond;
            int userNumberThird;

            Console.WriteLine("Enter number 1 to 10");
            userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 1 to 10");
            userNumberSecond = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 1 to 10");
            userNumberThird = int.Parse(Console.ReadLine());

            if (userNumber > userNumberSecond && userNumber < userNumberThird)
            {
                Console.WriteLine($"Your number is {userNumber}");
            }
            else if (userNumberSecond > userNumber && userNumberSecond > userNumberThird)
            {
                Console.WriteLine($"Your number is {userNumberSecond}");
            }
            else
            {
                Console.WriteLine($"Your number is {userNumberThird}");
            }
            Console.ReadLine();*/



            //Random number generator:


            /* Random randomGenerator = new Random();
             int userNumber;
             int randomNumber = randomGenerator.Next(1,7);//esimene arv on kaasaarvatud ning viimane on väljaarvatud

             Console.WriteLine("(Trow a dice)Enter number from 1 to 6");
             userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(randomNumber);


             if (userNumber > randomNumber)
             {
                 Console.WriteLine("You are winner!");
             }
             else if (userNumber < randomNumber)
             {
                 Console.WriteLine("Computer is winner!");
             }
             else
             {
                 Console.WriteLine("Try again, tie!");
             }

             Console.ReadLine();*/

            /*int userRoll;
            int cpuRoll;
            int rolls =0; //katse, mitu korda ma viskan
            int userScore = 0;
            int cpuScore = 0;

            Random rnd = new Random();
            while (rolls < 3)
            {
                userRoll = rnd.Next(1, 7);
                cpuRoll = rnd.Next(1, 7);
                Console.WriteLine($"You rolled {userRoll}, cpu rolled {cpuRoll}");

                if (userRoll > cpuRoll)
                {
                    //userRoll = userRoll + 1;
                    userScore++;
                }
                else if (userRoll< cpuRoll)
                {
                    cpuScore++;
                }
                else
                {
                    continue;
                }
                rolls++;
                Console.ReadLine();
            }
            if (userScore > cpuScore)
            {
                Console.WriteLine("Congratulation! You won!");
            }

            else if (userScore < cpuScore)
            {
                Console.WriteLine("Ups you lost. Try again.");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
            Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}");
            Console.ReadLine();*/

            /*Random rnd = new Random();
            int randomNumber = rnd.Next(1, 6);
            Console.WriteLine($"CPU generated {randomNumber}");

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("CPU generated nothing!");
                    break;
            }

            Console.ReadLine();*/

            Console.WriteLine("Pick a color (red, black, blue):");
            string answer = Console.ReadLine();

            switch (answer)//objekt, mille annad kontrolliks
            {
                case "red":
                    Console.WriteLine("You are a romantic type");
                    break;
                case "black":
                    Console.WriteLine("You are singel");
                    break;
                case "blue":
                    Console.WriteLine("You are in love with sea");
                    break;
                default:
                    Console.WriteLine("Cannot regonize the color");
                    break;
           
            }
            Console.ReadLine();
        }
    }
}
