using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask3
{
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //   s
        //    int[] numbers = { 5, 2, 9, 1, 7 };

        //   
        //    int enkiçik = numbers[0];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < enkiçik)
        //        {
        //            enkiçik = numbers[i];
        //        }
        //    }

        //    
        //    Console.WriteLine("Sıradakı en kiçik element: " + enkiçik);
        //}

        static void Main(string[] args)
        {
           
            //String[] arr = { "yusif", "rasul", "enver" };
            //String[] test = new string[arr.Length];

            //for (int i =arr.Length-1;i>=0;i--)
            //{
            //    test[arr.Length-1-i] = arr[i];
            //    Console.WriteLine(test[i]);
            //}
            //for (int i =0; i<arr.Length;i++)
            //{
            //    Console.WriteLine(test[i]);

            //}

            
        }
        static void Main2(string[] args)
        {
            int[] arr = { -2, 3, 4, -5 };
            int[] newarr = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                newarr[arr.Length - i-1] = arr[i];
            }
            Console.Write("cap");

            for(int i = 0;i < arr.Length;i++)
            {

                Console.Write(newarr[i]);
                Console.Write(newarr[i]);
                if (i < arr.Length- 1)
                {
                    Console.Write(",");
                }
                Console.WriteLine("cap");
            }

        }


    }

}
