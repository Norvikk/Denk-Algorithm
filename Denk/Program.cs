global using System;

namespace Denk
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denk by Norvik | V. 1\\\n");
            string _protocol = "";

            _protocol = Kenny.Loops.GetUserAnswer("Decrypt an existing file or Encrypt a new File \n[1] Encrypt\n[2] Decrypt",CharList: "123",DespiseItem: "0");

            if(_protocol == "1") // Encrypt
            {
                string _messageData = Kenny.Loops.GetUserAnswer("What do you want to encrypt? Paste it here:");
                string _iterationData = Kenny.Loops.GetUserAnswer("How many characters should each key have?", DespiseItem: "0", CharList: "123");
                // Console.WriteLine(DeenK.Process.Encrypt.StartRoot(Convert.ToInt32(iterationInput), messageInput));
            }
            else if(_protocol == "2") // Decrypt
            {
                string _brickedDataPath = Kenny.Loops.GetUserAnswer("Pass the path to your encrypted data: ");
                string _keysDataPath = Kenny.Loops.GetUserAnswer("Pass the path to your decryption keys: ");
                // Console.WriteLine(DeenK.Process.Decrypt.DecryptExpired(%%)
            }
            else { throw new Exception($"There is no such thing as {_protocol}. Check input"); }
        }
    }
}
