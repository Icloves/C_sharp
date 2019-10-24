using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int n = int.Parse(Console.ReadLine());
            double[] nums = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                nums[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int b = i; b < n; b++)
                {
                    
                    if  ((nums[i] != nums[b]) && ((nums[i]+nums[b]) % 1 == 0))
                    {
                        Console.WriteLine(nums[i]);
                        Console.WriteLine(nums[b]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
        
    
