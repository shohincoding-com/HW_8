using System;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter R = new Converter(0.099, 0.11, 7.13);
            Console.WriteLine("Выберите пожалуйста один из вариантах конвертации:\n\n1. SMN => USD\n2. SMN => EUR\n3. SMN => RUB\n4. USD => SMN\n5. EUR => SMN\n6. RUB => SMN");
            int ConNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пожалуйста сумма для конвертация!");
            double mon = double.Parse(Console.ReadLine());

            switch (ConNumb)
            {
                case 1:
                    Console.WriteLine($"{mon} сомони => {Math.Round(Converter.SmnToUsd(mon), 4)} доллар");
                    break;
                case 2:
                    Console.WriteLine($"{mon} сомони => {Math.Round(Converter.SmnToEur(mon), 4)} евро");
                    break;
                
                case 3:
                    Console.WriteLine($"{mon} сомони => {Math.Round(Converter.SmnToRub(mon), 4)} рублей");
                    break;
                case 4:
                    Console.WriteLine($"{mon} доллар => {Math.Round(Converter.UsdToSmn(mon), 4)} сомони");
                    break;
                case 5:
                    Console.WriteLine($"{mon} доллар => {Math.Round(Converter.EurToSmn(mon), 4)} сомони");
                    break;
                case 6:
                    Console.WriteLine($"{mon} доллар => {Math.Round(Converter.RubToSmn(mon), 4)} сомони");
                    break;
                
            }
                
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

        
            public static double SmnToUsd(double smn)
            {
                double C_us = smn * usd;
                return C_us;
            }
            public static double SmnToEur(double smn)
            {
                double C_eu = smn * eur;
                return C_eu;
            }
            public static double SmnToRub(double smn)
            {
                double C_rb = smn * rub;
                return C_rb;
            }

            public static double UsdToSmn(double C_us)
            {
            
                double smn = C_us / usd;
                return smn;
            }
            public static double EurToSmn(double C_eu)
            {
                double smn = C_eu / eur;
                return smn;
                
            }
            public static double RubToSmn(double C_rb)
            {
                double smn = C_rb / rub;
                return smn;
            }

            
        }

       
    }

