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
        public static void Start(int iterations, string data)
        {
            string[] _dataToArray= data.ToCharArray().ToString().ToArray;

            List<string> Keys = new();
            List<string> EncryptedLoad = new();

            foreach (string c in _dataToChar)
            {
                if (!Keys.Contains(c.ToString()))
                {
                    Keys.Add(c.ToString());
                    Keys.Add(GenerateKey(iterations));
                }
                if (Keys.Contains(c.ToString()))
                {
                    EncryptedLoad.Add(Keys[Keys.FindIndex(a => a.Contains(c.ToString())) + 1]);
                }
            }

            ListW(Keys, spacer: "---");
            Space();
            ListW(EncryptedLoad);

            Space();
            Space();

            foreach (string key in EncryptedLoad)
            {
                W(Keys[Keys.FindIndex(a => a.Contains(key)) - 1]);
            }

            RL();
        }

        private static string GenerateKey(int size) => Kenny.Get._SecureRandomAllString(size);
    }
}
