using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenny
{
    public static class Get
    {
        public static string _UserAnswer(
            string Question,
            int timeout = 1000,
            string DespiseItem = "Cartman",
            string CharList = "all"
        )
        {
            string rulers;
            switch (CharList)
            {
                case "all":
                    rulers = "1234567890qwertzuiopasdfghjklyxcvbnm";
                    break;
                case "abc":
                    rulers = "qwertzuiopasdfghjklyxcvbnm";
                    break;
                case "123":
                    rulers = "1234567890";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("The Rulers type", CharList);
            }
            Console.WriteLine(Question);
            string? temp_var_QuestionCarrier = Console.ReadLine();
            string temp_string_QuestionCarrier = Convert.ToString(temp_var_QuestionCarrier);

            static bool ContainsThis(string thisString, char[] theseChars) =>
                thisString.IndexOfAny(theseChars) != -1;

            if (DespiseItem != "Cartman") // If the user has a despised Item
            {
                if (
                    string.IsNullOrEmpty(temp_string_QuestionCarrier)
                    || temp_string_QuestionCarrier == DespiseItem
                    || !ContainsThis(temp_string_QuestionCarrier, rulers.ToCharArray())
                )
                {
                    while (
                        string.IsNullOrEmpty(temp_string_QuestionCarrier)
                        || temp_string_QuestionCarrier == DespiseItem
                        || !ContainsThis(temp_string_QuestionCarrier, rulers.ToCharArray())
                    )
                    {
                        Console.WriteLine("That didn't quite work, try again!");
                        System.Threading.Thread.Sleep(timeout);
                        Console.WriteLine("\n\n" + Question);
                        temp_string_QuestionCarrier = Console.ReadLine();
                        Console.Clear();
                    }
                    return temp_string_QuestionCarrier;
                }
            }
            else
            {
                if (
                    string.IsNullOrWhiteSpace(temp_string_QuestionCarrier)
                    || !ContainsThis(temp_string_QuestionCarrier, rulers.ToCharArray())
                )
                {
                    while (
                        string.IsNullOrEmpty(temp_string_QuestionCarrier)
                        || !ContainsThis(temp_string_QuestionCarrier, rulers.ToCharArray())
                    )
                    {
                        Console.WriteLine("That didn't work really well.. Try again");
                        System.Threading.Thread.Sleep(timeout);
                        Console.WriteLine("\n\n" + Question);
                        temp_string_QuestionCarrier = Console.ReadLine();
                        Console.Clear();
                    }
                    return temp_string_QuestionCarrier;
                }
            }
            return temp_string_QuestionCarrier;
        }

        public static int _RandomSecureInt(int min, int max) =>
            System.Security.Cryptography.RandomNumberGenerator.GetInt32(min, max);

        public static string _SecureRandomUpperString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[_RandomSecureInt(0, s.Length )])
                    .ToArray()
            );
        }

        public static string _SecureRandomLowerString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[_RandomSecureInt(0, s.Length)])
                    .ToArray()
            );
        }

        public static string _SecureRandomMixedString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[_RandomSecureInt(0, s.Length)])
                    .ToArray()
            );
        }

        public static string _SecureRandomAllString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%&()*.,-/:;><=?@[]^_'{]|";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[_RandomSecureInt(0, (s.Length - 1))])
                    .ToArray()
            );
        }

        public static string _SecureRandomSymbol(int length)
        {
            const string chars = "!#$%&()*.,-/:;><=?@[]^_'{]|~ ";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[_RandomSecureInt(0, s.Length)])
                    .ToArray()
            );
        }

        public static string[]? _LinesFromFile(string path)
        {
            try
            {
                return System.IO.File.ReadAllLines(@path);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR RETRIEVERING LINES FROM FILE; ERROR: " + e);
                return null;
            }
        }
    }
}
