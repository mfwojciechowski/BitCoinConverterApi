using System;
using System.Threading.Tasks;

namespace BitCoinConverterApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj ilosc BTC: ");
            float BTC = float.Parse(Console.ReadLine());

            Task<BitCoinData> respone = ApiConnection.getActualRate();
            BitCoinData ActualRate = respone.Result;

            Console.WriteLine($"Aktualny kurs BTC: {ActualRate.bpi.PLN.rate_float} ");
            Console.WriteLine($"Twoje BTC jest warte: {BTC * ActualRate.bpi.PLN.rate_float} PLN");

            Console.ReadKey();
        }
    }
}
