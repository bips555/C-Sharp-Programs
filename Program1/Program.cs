using System;
namespace DiceRollRandomExample{
public class Program{
    public static void Main(string[] args){
        Random dice = new Random();
        int roll = dice.Next(0, 10);
        Console.WriteLine($"Roll is: {roll}");
    }
}
}