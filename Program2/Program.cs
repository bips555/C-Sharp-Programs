using System;
namespace DiceRollRandomExampleOvrload{
    public class Program{
        public static void Main(string[] args){
            Random dice  = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(1,10);
          int roll3 = dice.Next(20);
          Console.WriteLine($"roll1 is {roll1} \t roll2 is {roll2} \t roll3 is {roll3}");    
        }
    }
}