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
            
            List<string> Keys = new();
            List<string> EncryptedLoad = new();
            WL(data);

            foreach (char c in data)
            {
                if (!Keys.Contains(c.ToString()))
                {
                    Keys.Add(c.ToString());
                    Keys.Add(GenerateKey(iterations));
                }
            }

            foreach (char c in data)
            {
                EncryptedLoad.Add(Keys[ Keys.IndexOf(c.ToString()) + 1]);
            }

            ListW(Keys);
            Space();
            ListW(EncryptedLoad);
            Space();
           
            foreach(string crypted in EncryptedLoad)
            {
                W(Keys[Keys.IndexOf(crypted) - 1]);
            }
        }

        private static string GenerateKey(int length) => _SecureRandomAllString(length);
    }
}
