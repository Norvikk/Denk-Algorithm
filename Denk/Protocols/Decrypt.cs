using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denk.Protocols
{
    using static Kenny.Get;
    using static Kenny.Set;
    using static Kenny.Utilities;

    internal static class Decrypt
    {
        public static void Start(string brickedPath, string keysPath)
        {
            List<string> Keys = new();
            List<string> EncryptedLoad = new();

            string[] _carrier1 = File.ReadAllText(keysPath).Split("~");
            foreach (string _carrier in _carrier1)
            {
                Keys.Add(_carrier);
            }

            string _carrier2 = File.ReadAllText(brickedPath);

            int chunkSize = Keys[1].Length;
            int stringLength = _carrier2.Length;
            for (int i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength)
                    chunkSize = stringLength - i;
                EncryptedLoad.Add(_carrier2.Substring(i, chunkSize));
            }

            foreach (string crypted in EncryptedLoad)
            {
                W(Keys[Keys.IndexOf(crypted) - 1]);
            }
        }
    }
}
