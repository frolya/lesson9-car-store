using System;

namespace CarStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cars [] car = new Cars [2];
            for (int i = 0; i<car.Length; i++)
            {
                car[i] = new Cars();
                Console.WriteLine("Input Name");
                car[i].Name = Console.ReadLine();

                Console.WriteLine("Input Color");
                car[i].Color = Console.ReadLine();

                Console.WriteLine("Input Price");
                car[i].Price = int.Parse(Console.ReadLine());

                Console.WriteLine($"Source Price: {car[i].Price}, Price after sale: {car[i].GetSale()}");

            }

            

        }
    }
}