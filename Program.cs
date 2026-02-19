namespace Calculator_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kaç adet sayı ile işlem yapmak istiyorsunuz?");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Adet Giriniz: ");
            Console.ResetColor();
            int adet = int.Parse(Console.ReadLine());

            double[] sayilar = new double[adet];

            // veri girişi için döngü
            for (int i = 0; i < adet; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                sayilar[i] = double.Parse(Console.ReadLine());
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n--- SONUÇLAR ---");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Toplam : {Topla(sayilar):f2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Çıkarma : {Cikar(sayilar):f2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Çarpma : {Carp(sayilar):f2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Bölüm : {Bol(sayilar):f2}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (adet >= 2)
            {                
                Console.WriteLine($"İlk iki sayının Modu ({sayilar[0]} % {sayilar[1]}): {ModAl(sayilar[0], sayilar[1])}");                
            }
            Console.ResetColor();            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nSayıların Faktöriyelleri:");
            Console.ResetColor();
            // Sonuçları yazdırmak için for döngüsü
            for (int i = 0; i < sayilar.Length; i++)
            {
                int tamsayi = (int)sayilar[i];
                Console.WriteLine($"{tamsayi}! = {Faktoriyel(tamsayi)}");
            }
            Console.Read();
        }
        static double ModAl(double a, double b) => a % b;
        static double Topla(double[] sayi)
        {
            double sonuc = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                sonuc += sayi[i];
            }
            return sonuc;
        }
        static double Cikar(double[] sayi)
        {
            double sonuc = sayi[0];
            for (int i = 1; i < sayi.Length; i++)
            {
                sonuc -= sayi[i];
            }
            return sonuc;
        }
        static double Carp(double[] sayi)
        {
            double sonuc = 1;
            for (int i = 0; i < sayi.Length; i++)
            {
                sonuc *= sayi[i];
            }
            return sonuc;
        }
        static double Bol(double[] sayi)
        {
            double sonuc = sayi[0];
            for (int i = 1; i < sayi.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (sayi[i] == 0)
                {
                    Console.WriteLine("\nHata: 0'a bölme işlemi yapılamaz!");
                    Console.ResetColor();
                    return 0;
                }               
                sonuc /= sayi[i];
            }
            return sonuc;
        }
        static long Faktoriyel(int n)
        {
            if (n < 0) return 0;
            long sonuc = 1;
            for (int i = 1; i <= n; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }        
    }
}
