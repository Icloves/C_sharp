using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int n = int.Parse(Console.ReadLine());

            string[] nums = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                nums[i] = (Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                string first = nums[i];
                for (int b = i + 1; b < n; b++)
                {
                    string second = nums[b];
                    bool firstContainsDigitFromSecond = false;
                    for (int c = 0; c < first.Length; c++)
                    {
                        if (second.Contains(first[c]))
                        {
                            firstContainsDigitFromSecond = true;
                            break;
                        }
                    }
                    if (!firstContainsDigitFromSecond)
                    {
                        Console.WriteLine(first);
                        Console.WriteLine(second);
                    }
                }
                Console.ReadLine();

            }
            
        }
        
    }
}






