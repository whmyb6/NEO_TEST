using System;

namespace Console_ConvertPUB_key
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string custom_public_key = "03d99b128ebb04fb9c1ecf313fe9d9846f7a6ece4bf6cc6da6999d3ec09c2dfc19";
            byte[] b = HexToBytes(custom_public_key);
            foreach(var item in b)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadLine();

        }

        private static byte[] HexToBytes(string hexString)
        {
            //throw new NotImplementedException();
            hexString = hexString.Trim();
            byte[] returnBytes = new byte[hexString.Length /2 ];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);

            }
            return returnBytes;
        }
    }
}
