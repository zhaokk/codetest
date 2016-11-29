using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("qustion number?(1 or 2) exit type e");
                string option = Console.ReadLine();
                string result;
                if (option == "1")
                {
                    Console.WriteLine("what do you want to do shuffle or reverse?(type in 1 or 2)");
                    string option2 = Console.ReadLine();
                    if (option2 == "1")
                    {
                        Console.WriteLine("input the string you want to shuffle");
                        string myString = Console.ReadLine();
                        result = shuffle(myString);
                    }
                    else
                    {
                        Console.WriteLine("input the string you want to reverse");
                        string myString = Console.ReadLine();
                        result = Reverse(myString);
                    }
                    Console.WriteLine(result);

                }
                else if (option == "2")
                {

                    Console.WriteLine("input the int array you want to find median(example:0 2 3 4 5 6 7)");
                    string myString = Console.ReadLine();
                    string[] numbers = myString.Split(' ');
                    if (numbers[numbers.Length - 1].Equals(""))
                    {
                        numbers = numbers.Take(numbers.Count() - 1).ToArray();
                    }

                    int[] intArray = new int[numbers.Length];
                    int index = 0;
                    int x;

                    foreach (var number in numbers)
                    {

                        bool isNumber = Int32.TryParse(number, out x);
                        if (!isNumber)
                        {
                            Console.WriteLine("plz enter number only, you have entered:");
                            Console.WriteLine("start" + myString + "end");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        intArray[index] = x;
                        index++;
                    }
                    findMedian(intArray);

                }
                else {
                    Environment.Exit(0);
                }
            }
           

            
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string shuffle(string s)
        {
            char[] charArray = s.ToCharArray();
            char[] shuffled = new char[charArray.Length];
            Random random = new Random();
            int rNo;
            for (int i = charArray.Length; i >= 1; i--)
            {
                rNo = random.Next(1, i + 1) - 1;
                shuffled[i - 1] = charArray[rNo];
                charArray[rNo] = charArray[i - 1];
            }
            return new string(shuffled);
        }
        public static int findMedian(int[] array)
        {
            Array.Sort<int>(array,
                            new Comparison<int>(
                                    (item1, item2) => item2.CompareTo(item1)
                            ));
            if (array.Length % 2 == 0)
            {
                Console.WriteLine("even number of numbers there are two median value");
                Console.WriteLine(array[array.Length / 2]);
                Console.WriteLine(array[array.Length / 2 - 1]);
            }
            else {
                Console.WriteLine("odd number of numbers there are one median value");
                Console.WriteLine(array[array.Length / 2] );
            }
            return 0;
        }
    }
}
