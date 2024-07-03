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

            #region Dizi içerisindeki sayıların ortalamasını buldurunuz - ÖDEV

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

            #region Dizi içerisindeki en küçük sayıyı bulunuz - ÖDEV

            //int enkucuk = sayilar[0];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < enkucuk)
            //    {
            //        enkucuk = sayilar[i];
            //    }

            //}
            //Console.WriteLine("En kücük sayı: " + enkucuk);

            #endregion

            #region Dizi içerisindeki en büyük sayı ile en küçük sayının yerini değiştiriniz - ÖDEV
            //int enkucuk = sayilar[0];
            //int indexenkucuk = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] < enkucuk)
            //    {
            //        enkucuk = sayilar[i];
            //        indexenkucuk = i;
            //    }
            //}
            //Console.WriteLine("En kücük sayı: " + enkucuk);
            //Console.WriteLine(indexenkucuk);

            //int enbuyuk = sayilar[0];
            //int indexenbuyuk = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > enbuyuk)
            //    {
            //        enbuyuk = sayilar[i];
            //        indexenbuyuk = i;
            //    }
            //}
            //Console.WriteLine("En büyük sayı: " + enbuyuk);
            //Console.WriteLine(indexenbuyuk);
           
            //sayilar[11] = enbuyuk;
            //sayilar[12] = enkucuk;

            //for (int i = 0;     i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion
        }
    }
}