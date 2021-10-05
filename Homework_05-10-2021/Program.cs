using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача №1
           int[] arr = new int[10];
           Random rnd = new Random();
           for(int i = 0; i < arr.Length; i++)
           {
               arr[i] = rnd.Next(5);
               Console.Write(arr[i] + " ");
           }
           Console.WriteLine();

           for(int i = 0; i < arr.Length; i++)
           {
               if (arr[i] == 0)
               {
                   while(arr[i] == 0)
                   {
                       for (int j = i; j < arr.Length - 1; j++)
                       {
                           arr[j] = arr[j + 1];
                       }
                       arr[arr.Length - 1] = -1;
                   }
               }                 
           }


           for (int i = 0; i < arr.Length; i++)
           {
               Console.Write(arr[i] + " ");
           }
           Console.WriteLine();*/


            /*Задача №2 (Not fin)
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] >= 0)
                {
                    if (arr[i + 1] < 0)
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                    else
                    {
                        for (int index = i; index < arr.Length; index++)
                        {
                            if (arr[index] < 0)
                            {
                                int tmp = arr[i];
                                arr[i] = arr[index];
                                arr[index] = tmp;
                                break;
                            }
                        }
                    }
                }
            }



            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();*/

            string tmp;
            Console.WriteLine("Enter the quantity of rows:\t");
            tmp = Console.ReadLine();
            int rows = Convert.ToInt32(tmp);
            Console.WriteLine("Enter the quantity of columns:\t");
            tmp = Console.ReadLine();
            int columns = Convert.ToInt32(tmp);
            int [,] arr = new int [rows, columns];
            Random rnd = new Random();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    arr[i, j] = rnd.Next(30);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
