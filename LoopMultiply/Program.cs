using System;
using System.Linq;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int numInput = int.Parse(Console.ReadLine());
            int[] numbers = new int[19];
            int sum = 0;

            //int number = 0;
            for (int i = 2; i < 21; i++)          
            {

                numbers = new int[] { i * numInput };
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);

                    sum += number;
                }
                        
                //int sum = numbers.Sum();
                //Console.WriteLine(sum);                                            
             }
            
            Console.WriteLine(sum);
            Console.ReadLine();
            } 
            

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 

            // TODO: When the loop is finished, output the sum of all previous values.

            
        }
    }

