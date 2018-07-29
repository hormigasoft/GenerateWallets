using System;
using NBitcoin.Accounts;
using Nethereum.Accounts;

namespace GenerateWallets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Seed for both ETH and BTC
            string seed = "This is the seed";

            Console.WriteLine("");
            Console.WriteLine("Generating ETH and BTC addresses & private keys...");
            Console.WriteLine("");

            // Generate ETH KeyStore file
            try
            {
                string path = "C:\\GENKEYS\\ETH";
                ETHaccountCreator ETHgenKeys = new ETHaccountCreator();
                var ETHaddress = ETHgenKeys.CreateAccount(seed, path);
                Console.WriteLine("ETH keyStore file: " + ETHaddress);
                Console.WriteLine("Saved to: " + path);
                Console.WriteLine("");
            }
            catch (Exception x) {
                Console.WriteLine("Error generating ETH keys:" + x.Message);
                Console.WriteLine("");
            }

            // Generate BTC KeyStore file
            try
            {
                string path = "C:\\GENKEYS\\BTC";
                BTCaccountCreator BTCgenKeys = new BTCaccountCreator();
                var BTCaddress = BTCgenKeys.CreateAccount(seed, path);
                Console.WriteLine("BTC keyStore file: " + BTCaddress);
                Console.WriteLine("Saved to: " + path);
                Console.WriteLine("");
            }
            catch (Exception x) {
                Console.WriteLine("Error generating BTC keys:" + x.Message);
                Console.WriteLine("");
            }
        }
    }
}
