using System;
using System.Numerics;
using System.IO;

namespace bitQuantum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] bit = new string[64];

            Complex c2 = Complex.FromPolarCoordinates(1,Math.PI/32);

            for (int i = 0; i < 64; i++)
            {
                Complex c1 = Complex.Pow(c2, i);
                Console.WriteLine("j^{0}= magnitude={1:N}. angle={2:N} degrees", 
                                  i, c1.Magnitude, c1.Phase * 180 / Math.PI);
                Console.WriteLine("j^{0}= {1:N}+j{2:N}\n", i , c1.Real, c1.Imaginary);
                bit[i]=String.Format("{0:N},{1:N},{2:N}",i,c1.Real,c1.Imaginary);
            }
            File.WriteAllLines("bit.csv", bit);
            Console.WriteLine("calculation complete");
            Console.WriteLine("csv file written");
        }
    }
}
