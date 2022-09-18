using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Denk.Protocols
{
    using static Kenny.Get;
    using static Kenny.Set;
    using static Kenny.Utilities;

    internal static class Encrypt
    {
        public static async void Start(int iterations, string data)
        {
            List<string> Keys = new();
            List<string> EncryptedLoad = new();
            AssignKeys(ref Keys, data, iterations);

            foreach (char c in data)
            {
                EncryptedLoad.Add(Keys[Keys.IndexOf(c.ToString()) + 1]);
            }

            string path = _UserAnswer("Where should the files be saved to?");

            using StreamWriter sw1 = new(@path + @"\Encrypted.txt");
            foreach (string crypt in EncryptedLoad)
            {
                sw1.Write(crypt);
            }

            using StreamWriter sw2 = new(@path + @"\Keys.txt");
            foreach (string key in Keys)
            {
                sw2.Write(key + "~");
            }
        }

        private static string GenerateKey(int length) => _SecureRandomAllString(length);

        private static void AssignKeys(ref List<string> Keys, string data, int iterations)
        {
            foreach (char c in data)
            {
                if (!Keys.Contains(c.ToString()))
                {
                    Keys.Add(c.ToString());
                    Keys.Add(GenerateKey(iterations));
                }
            }
        }
    }
}
