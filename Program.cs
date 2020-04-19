using System;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Converter
    {
        public static double usd { get; set; }
        public static double eur { get; set; }
        public static double rub { get; set; }

        public Converter(double C_us, double C_eu, double C_rb)
        {
            usd = C_us;
            eur = C_eu;
            rub = C_rb;
        }
    }
}
