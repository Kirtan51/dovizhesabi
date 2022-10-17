using System;

namespace KurHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double miktarTL, miktarUSD, miktarEUR;
            double dolarkuru, eurokuru;
            double toplam;

            Console.Write("Dolar kurunu giriniz:");
            dolarkuru = double.Parse(Console.ReadLine());

            Console.Write("Avro kurunu giriniz:");
            eurokuru = double.Parse(Console.ReadLine());

            Console.Write("Türk Lirası(TL) miktarını giriniz:");
            miktarTL = double.Parse(Console.ReadLine());

            Console.Write("Dolar(USD) miktarını giriniz:");
            miktarUSD = double.Parse(Console.ReadLine());

            Console.Write("Euro(EUR) miktarını giriniz:");
            miktarEUR = double.Parse(Console.ReadLine());

            toplam = miktarUSD * dolarkuru + miktarEUR * eurokuru+ miktarTL;
            Console.WriteLine("{0} kadar TL'niz var.", toplam);
        }
    }
}
