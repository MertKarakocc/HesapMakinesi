class Program
{
    static void Main(string[] args)
    {
       
       
         basla:
            Console.WriteLine("2 Adet Sayı Giriniz");
            Console.WriteLine("-------------------");
            int numara1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------");
            int numara2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------");
        seçim:
            Console.WriteLine("Yapıcağınız işlemi Seçiniz");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Sonuç= " + toplama(numara1, numara2));
                    goto basla;
                case 2:
                    Console.WriteLine("Sonuç= " + çıkarma (numara1, numara2));
                    goto basla;
                case 3:
                    Console.WriteLine("Sonuç= " + çarpma(numara1, numara2));
                    goto basla;
                case 4:
                    Console.WriteLine("Sonuç= " + bölme(numara1, numara2));
                    goto basla;
                default:
                    Console.WriteLine("Yanlış İşlem Seçtiniz Tekrar giriniz");
                    goto seçim;
            
           
        }
      
    }
    public static int toplama(int numara1, int numara2)
    {
        return numara1  + numara2;
    }
    public static int çıkarma(int numara1, int numara2)
    {
        return numara1 - numara2;
    }
    public static int çarpma(int numara1, int numara2)
    {
        return numara1 * numara2;
    }
    public static double bölme(int numara1, int numara2)
    {
        return numara1 / numara2;
    }
}