using System;
using System.Collections.Generic;


namespace puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] newArr = new int[10];
            newArr[0] = rand.Next(5,25);
            int max = newArr[0];
            int min = newArr[0];
            int sum = 0;
            for(int i=1; i<newArr.Length; i++)
            {
                newArr[i] = rand.Next(5,25);
                if(newArr[i] > max)
                {
                    max = newArr[i];
                }
                if(newArr[i] < min)
                {
                    min = newArr[i];
                }
                sum += newArr[i];
                System.Console.WriteLine(newArr[i]);
            }
            System.Console.WriteLine($"Max: {max}");
            System.Console.WriteLine($"Min: {min}");
            System.Console.WriteLine($"Sum: {sum}");
        }

        public static Double TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            int num = rand.Next(1,10);
            if(num >= 5)
            {
                System.Console.WriteLine("heads");
            }
            else
            {
                System.Console.WriteLine("tails");
            }
            return(num);
        }

        public static Double TossMultipleCoins(int num)
        {
            double a = 0;
            double b = 0;
            for(int i=0; i<num; i++)
            {
                if(TossCoin() >= 5)
                {
                    a += 1;
                }
                else
                {
                    b += 1;
                }
            }
            double ratio = a/b;
            return ratio;
        }



        public static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Remove("Todd");
            names.Add("Todd");
            names.Remove("Charlie");
            names.Add("Charlie");
            List<string> Lgnames = new List<string>();

            foreach(string name in names)
            {
                Console.WriteLine("-"+ name);
            }
            foreach(string name in names)
            {
                if(name.Length > 5)
                {
                    Lgnames.Add(name);
                }
            }
            return Lgnames;
        }

        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // Console.WriteLine("Heads to Tails Ratio =" + TossMultipleCoins(5));
            System.Console.WriteLine(Names());
        }
    }
}
