using System;

namespace ControlFlow
{

    class Program
    {
        static void Main(string[] args)
        {
            /*          This demonstrates a conditional operator


                        bool isGoldCustomer = true;

                        float price = (isGoldCustomer) ? 19.95f : 29.95f;

                        Console.WriteLine("Price "+ price);
            */
            Console.WriteLine("Please Enter a season: ");
            Console.WriteLine(" 1.) Autumn");
            Console.WriteLine(" 2.) Winter");
            Console.WriteLine(" 3.) Spring");
            Console.WriteLine(" 4.) Summer");
            Console.WriteLine("\nPlease Enter a season: ");

            string user_input;

            var name = "Jason Johnson";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var Character in name)
            {
                Console.WriteLine(Character);
            }
            user_input = Console.ReadLine();
            int value = Convert.ToInt32(user_input);
            var season = Season.Autumn;

            switch (value)
            {
                case 1:
                    season = Season.Autumn;
                    break;
                case 2:
                    season = Season.Winter;
                    break;
                case 3:
                    season = Season.Spring;
                    break;
                case 4:
                    season = Season.Summer;
                    break;


            }

            var numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
              numbers[i] = new Random(100).Next(100);
            }
            foreach (var index in numbers)
            {
                Console.WriteLine(index);

            }

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Autumn is my favorite Season!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Arizona is too hot in the Summer!");
                    break;
                case Season.Winter:
                    Console.WriteLine("Arizona has the best winters in the Country!");
                    break;
                case Season.Spring:
                    Console.WriteLine("The Spring in Arizona is pretty good, but it gets hot in May.");
                    break;
            }
        }
    }
}
