using System;

namespace Kenny
{
    public static class Loops
    {
        public static string GetUserAnswer(
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
    }

    public static class GetA
    {
        public static int RandomSecureNumber(int fromInclusive, int toExclusive) =>
            System.Security.Cryptography.RandomNumberGenerator.GetInt32(fromInclusive, toExclusive);

        public static string GetSecureRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(
                Enumerable
                    .Repeat(chars, length)
                    .Select(s => s[RandomSecureNumber(0, s.Length)])
                    .ToArray()
            );
        }
    }
}
