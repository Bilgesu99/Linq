using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // liste
        var sayilar = new List<int> { 5, 8, 9, 12, 85, 56, 42, 7, 21, 61 };

        // Listeyi ekrana yazdırıyoruz
        Console.WriteLine("Oluşturulan Sayılar:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }

        // Çift olan sayılar
        var ciftSayilar = sayilar.Where(sayi => sayi % 2 == 0);
        Console.WriteLine("Çift Sayılar:");
        foreach (var sayi in ciftSayilar)
        {
            Console.Write(sayi + " ");
        }

        var tekSayilar = sayilar.Where(sayi => sayi % 2 != 0);
        Console.WriteLine("Tek Sayılar:");
        foreach (var sayi in tekSayilar)
        {
            Console.Write(sayi + " ");
        }

        // Negatif sayılar
        var negatifSayilar = sayilar.Where(sayi => sayi < 0);
        Console.WriteLine("Negatif Sayılar:");
        foreach (var sayi in negatifSayilar)
        {
            Console.Write(sayi + " ");
        }

        var pozitifSayilar = sayilar.Where(sayi => sayi > 0);
        Console.WriteLine("Pozitif Sayılar:");
        foreach (var sayi in pozitifSayilar)
        {
            Console.Write(sayi + " ");
        }

        var araliktaSayilar = sayilar.Where(sayi => sayi > 15 && sayi < 22);
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar:");
        foreach (var sayi in araliktaSayilar)
        {
            Console.Write(sayi + " ");
        }

        // Her bir sayının karesi
        var kareler = sayilar.Select(sayi => sayi * sayi).ToList();
        Console.WriteLine("Her Bir Sayının Karesi:");
        foreach (var kare in kareler)
        {
            Console.Write(kare + " ");
        }
    }
}
