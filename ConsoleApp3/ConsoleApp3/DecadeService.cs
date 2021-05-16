using System;

namespace ConsoleApp3
{
    public class DecadeService
    {
        public int CalculateDecade(int years)
        {
            var result = years / 10;
            Console.WriteLine($"Ilość dekad: {result}");
            return result;
        }
    }
}
