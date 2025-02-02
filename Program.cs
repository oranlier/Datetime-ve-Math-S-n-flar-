﻿using System;

namespace Datetime_ve_Math_Sınıfları
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddHours(10));
            Console.WriteLine(DateTime.Now.AddMinutes(30));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTimeFormat
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); // saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Sin(-5));
            Console.WriteLine(Math.Cos(-5));
            Console.WriteLine(Math.Tan(-5));

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); //22
            Console.WriteLine(Math.Round(22.7)); //23
            Console.WriteLine(Math.Floor(22.3)); //22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); //3^4 getirir
            Console.WriteLine(Math.Sqrt(9)); // 9 un karekoku
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki karsılıgı
            Console.WriteLine(Math.Log10(10)); // 9 un 10 tabanındaki karsılıgı
            Console.WriteLine(Math.Exp(3)); // e uzeri 3 u verır

        }
    }
}
