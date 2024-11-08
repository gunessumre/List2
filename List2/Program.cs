using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveIsimleri = new List<string>();

        Console.WriteLine("Lütfen 5 kahve ismi giriniz:");
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahveAdi = Console.ReadLine();
            kahveIsimleri.Add(kahveAdi);
        }
        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string kahve in kahveIsimleri)
        {
            Console.WriteLine(kahve);
        }
    }
}