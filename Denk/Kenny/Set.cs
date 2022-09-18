using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenny
{
    public static class Set
    {
        public static void _UnderlineForeach(string message, string spacing = "")
        {
            Console.WriteLine(" " + message + " ");
            Console.Write(spacing);
            Console.Write("|");
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write("-");
            }
            Console.Write("|\n");
        }

        public static async Task _WriteToFile(string path, string[] data) =>
            await File.WriteAllLinesAsync(path, data);
    }
}
