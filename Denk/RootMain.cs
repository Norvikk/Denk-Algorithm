namespace Denk
{
    class Run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Denk by Norvik | V. 1\n");
            string _protocol = "1";

            //_protocol = Kenny.Get._UserAnswer("Decrypt an existing file or Encrypt a new File \n[1] Encrypt\n[2] Decrypt", CharList: "123", DespiseItem: "0");

            if (_protocol == "1") // Encrypt
            {
               // string _messageData = Kenny.Get._UserAnswer("What do you want to encrypt? Paste it here:");
               // string _iterationData = Kenny.Get._UserAnswer("How many characters should each key have?", DespiseItem: "0", CharList: "123");
                Kenny.Utilities.Clear();
                // Denk.Protocols.Encrypt.Start(Convert.ToInt32(_iterationData), _messageData);
                Denk.Protocols.Encrypt.Start(5, "Queen Of Blades");
            }
            else if (_protocol == "2") // Decrypt
            {
                string _brickedDataPath = Kenny.Get._UserAnswer("Pass the path to your encrypted data: ");
                string _keysDataPath = Kenny.Get._UserAnswer("Pass the path to your decryption keys: ");
                Kenny.Utilities.Clear();
                // Console.WriteLine(DeenK.Process.Decrypt.DecryptExpired(%%)
            }
            else { throw new Exception($"There is no such thing as {_protocol}. Check input"); }
        }
    }
}
