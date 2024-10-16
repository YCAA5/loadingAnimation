// * = buradaki değerler değiştirilebilir
using System;

namespace nitelikler 
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            
        for (int i = 0; i < 10; i++) // * 
        {
            Thread.Sleep(100); // *
            bool kontrol = true;
            while (kontrol)
                {
                    Console.Write("\rYükleniyor|");
                    Thread.Sleep(175);
                    Console.Write("\r");
                    Console.Write("\rYükleniyor/");
                    Thread.Sleep(175);
                    Console.Write("\r");
                    Console.Write("Yükleniyor-");
                    Thread.Sleep(175);
                    Console.Write("\r");
                    Console.Write("Yükleniyor\\");
                    Thread.Sleep(175);
                    kontrol = false;
                }
        }

        Console.WriteLine("\nAnimasyon durdu.");
        Console.ReadLine();  
        }
    }
}