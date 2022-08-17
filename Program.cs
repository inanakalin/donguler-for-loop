internal class Program
{
{{    private static void Main(string[] args)
    {
        // ekrandan girilen sayıya kadar olan tek sayıları yazdır
        Console.WriteLine("lütfen bir sayı giriniz");

        int sayac = int.Parse(Console.ReadLine());
        for (int i  = 1; i <= sayac; i++)
        {
            //komutlar
            if ( i % 2 ==1)
            Console.WriteLine(i);
        }
        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içindeki toplamını ekrana yazdır
            int tektoplam = 0;
            int cifttoplam = 0;

        for (int i = 1; i <= 1000; i++)
        {
            if (i%2 == 1)
            tektoplam += i;
            else 
            cifttoplam += i;
        }
        Console.WriteLine("tek Toplam: " + tektoplam);
        Console.WriteLine("Çift Toplam: " + cifttoplam);}}

        
       
 








    }
}