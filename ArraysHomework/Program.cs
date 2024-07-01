using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 25, 43, -20, 65, 1, 9, 15, 25, 65, -86, -4300, 123, 45, 12 };

            #region Dizi içerisindeki sayıların ortalamasını buldurunuz -ÖDEV

            //double toplam = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam = toplam + sayilar[i];
            //}
            //Console.WriteLine(toplam/sayilar.Length);

            #endregion

            #region Dizi içerisindeki çift sayıların ortalamasını bulunuz - ÖDEV
            //double toplam = 0;
            //int bolen = 0;

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    if (sayilar[i] % 2 == 0)
            //    {
            //        toplam = toplam + sayilar[i];
            //        bolen++;
            //    }
            //}
            //Console.WriteLine(toplam / bolen);

            #endregion

            #region Dizi içerisindeki pozitif sayıların adetini yazdırın - ÖDEV
            //int adet = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]>0)
            //    {
            //        adet++;
            //    }
            //}
            //Console.WriteLine(adet);
            #endregion

        }
    }
}