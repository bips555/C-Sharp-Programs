using System;
namespace DiceGame
{
    public class DiceGame
    {
        public static void Main(string[] args)
        {
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Your total of {roll1} + {roll2} + {roll3} is {total}");

            if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
            {

                if (roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("6 point bonus added to total\n");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("2 point bonus added to total\n");
                    total += 2;
                }
            }
            {

            }


            if (total > 14)
            {
                Console.WriteLine("You Win!");
            }
            else
            {
                Console.WriteLine("You Lose!");
            }
            Console.WriteLine(total);
        }
    }
}