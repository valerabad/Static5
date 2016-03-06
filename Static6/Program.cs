using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static6
{
    class Program
    {
        static void Main(string[] args)
        {
            int task;
            while (true)
            {
                Console.WriteLine("Enter task 1-3:");
                int.TryParse(Console.ReadLine(), out task);
                switch (task)
                {
                    case 1:
                        Console.WriteLine(Calculator.Sum(1, 2));
                        Console.WriteLine(Calculator.Diff(1, 2));
                        Console.WriteLine(Calculator.Mult(1, 2));
                        Console.WriteLine(Calculator.Div(1, 2));
                        break;
                    case 2:
                        int[] Array = new int[] { 10, 1, 9, 2, 3, 8, 4, 3, 7, 6, 5 };
                        Array.BubbleSort(false);
                        Console.WriteLine("Сортировка по возрвстанию:");
                        ArraySortClass.BubbleSort(Array, true);
                        break;
                    case 3:
                        string text = "test string 1234_567";
                        Console.WriteLine("Стандартный метод Substring(): {0}", text.Substring(10, 6));
                        Console.WriteLine("Собственный метод Sub_string(): {0}\n", text.Sub_String(10, 6));

                        Console.WriteLine("Стандартный метод IndexOf(): {0}", text.IndexOf("g"));
                        Console.WriteLine("Собственный метод Index_Of(): {0}\n", text.Index_Of("g"));

                        Console.WriteLine("Стандартный метод Replace(): {0}", text.Replace("st", "00"));
                        Console.WriteLine("Собственный метод Index_Of(): {0}\n", text.Replace_("st", "00"));
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                
            }
            Console.ReadKey();
        }
        
    }
}


