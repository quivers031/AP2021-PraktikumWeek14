using System;

namespace PraktikumWeek14
{
    internal class Program
    {
        public static void DeretPrima(int angkaUser)
        {
            int counter = 0;
            int angkaBerjalan = 0;
            int apakahPrima = 0;
            for (int i = 0; i < angkaUser; i++)
            {
                for (int j = 0; j < angkaUser; j++)
                {
                    apakahPrima = 0;
                    while (apakahPrima == 0)
                    {
                        angkaBerjalan++;
                        counter = 0;
                        for (int k = 1; k <= angkaBerjalan; k++)
                        {
                            if (angkaBerjalan % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                        {
                            apakahPrima = 1;
                        }
                        else
                        {
                            apakahPrima = 0;
                        }
                    }
                    Console.Write($"{angkaBerjalan} ".PadLeft(5));
                }
                Console.WriteLine();
            }
        }
        public static void DeretNonPrima(int angkaUser)
        {
            int counter = 0;
            int angkaBerjalan = 0;
            int apakahPrima = 0;
            for (int i = 0; i < angkaUser; i++)
            {
                for (int j = 0; j < angkaUser; j++)
                {
                    apakahPrima = 0;
                    while (apakahPrima == 0)
                    {
                        angkaBerjalan++;
                        counter = 0;
                        for (int k = 1; k <= angkaBerjalan; k++)
                        {
                            if (angkaBerjalan % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                            apakahPrima = 0;
                        else
                            apakahPrima = 1;
                    }
                    Console.Write($"{angkaBerjalan} ".PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int angkaUser = Convert.ToInt32(Console.ReadLine());    
            if (angkaUser < 2)
            {
                Console.WriteLine("Input salah, coba lagi lain waktu. bay");
            }
            else
            {
                Console.WriteLine("Output : ");
                int counter = 0;
                for (int i = 1; i <= angkaUser; i++)
                {
                    if (angkaUser % i == 0)
                    {
                        counter++;
                    }
                }
                if(counter == 2)
                {
                    DeretPrima(angkaUser);
                }
                else
                {  
                    DeretNonPrima(angkaUser);
                }
            }
        }
    }
}
