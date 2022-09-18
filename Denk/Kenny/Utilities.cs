using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenny
{
    public static class Utilities
    {
        public static void WL(string data) => Console.WriteLine(data);

        public static void WL(int data) => Console.WriteLine(data);

        public static void W(string data) => Console.Write(data);

        public static void W(int data) => Console.Write(data);

        public static void RL() => Console.ReadLine();

        public static void R() => Console.Read();

        public static void Sleep(int time) => System.Threading.Thread.Sleep(time);

        public static void Clear() => Console.Clear();

        public static void Space() => Console.WriteLine("\n");

        public static void ListW(List<string> list, string spacer = " ")
        {
            foreach (string item in list)
            {
                Console.Write(item + spacer);
            }
        }

        public static void ListW(List<int> list, string spacer = " ")
        {
            foreach (int item in list)
            {
                Console.Write(item + spacer);
            }
        }

        public static void ListWL(List<string> list, string spacer = " ")
        {
            foreach (string item in list)
            {
                Console.WriteLine(item + spacer);
            }
        }

        public static void ListWL(List<int> list, string spacer = " ")
        {
            foreach (int item in list)
            {
                Console.WriteLine(item + spacer);
            }
        }

        public static void ArrayW(string[] array, string spacer = " ")
        {
            foreach (string item in array)
            {
                Console.Write(item + spacer);
            }
        }

        public static void ArrayW(int[] array, string spacer = " ")
        {
            foreach (int item in array)
            {
                Console.Write(item + spacer);
            }
        }

        public static void ArrayWL(string[] array, string spacer = " ")
        {
            foreach (string item in array)
            {
                Console.WriteLine(item + spacer);
            }
        }

        public static void ArrayWL(int[] array, string spacer = " ")
        {
            foreach (int item in array)
            {
                Console.WriteLine(item + spacer);
            }
        }
    }
}
