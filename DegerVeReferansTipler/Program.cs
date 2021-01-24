using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;


            int[] sayilarInts1 = new int[] { 10, 50, 96 };
            int[] sayilarInts2 = new int[] { 100, 500, 960 };
            sayilarInts1 = sayilarInts2;
            sayilarInts2[0] = 999;
        }
    }
}
