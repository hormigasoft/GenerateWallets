using System;
using NBitcoin.Accounts;
using Nethereum.Accounts;

namespace GenerateWallets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Password for both ETH and BTC
            string password = "This is the password";

            Console.WriteLine("");
            Console.WriteLine("Generating ETH and BTC addresses & private keys...");
            Console.WriteLine("");

            // Generate ETH KeyStore file
            try
            {
                string path = "C:\\GENKEYS\\ETH";
                ETHaccountCreator ETHgenKeys = new ETHaccountCreator();
                var ETHaddress = ETHgenKeys.CreateAccount(password, path);
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
                var BTCaddress = BTCgenKeys.CreateAccount(password, path);
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
