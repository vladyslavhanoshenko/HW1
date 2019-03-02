using System;

namespace HW1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers: ");

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("User input finished. Processing...");

            for(int j = 0; j<arr.Length; j++)
            {
                    Console.Write(arr[j]*10 + " ");
                
            }
            Console.ReadLine();

        }
    }
}
