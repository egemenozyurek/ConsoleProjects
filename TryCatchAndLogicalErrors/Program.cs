using System;

namespace trycatchandlogicalerrors
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Lütfen bir sayı giriniz");
            //     int number1 = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmiş olduğunuz sayı: " + number1);
            // }
            // catch (Exception ex)
            // {
            //     // TODO
            //     Console.WriteLine("Hata: " + ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Sonlandırıldı");
            // }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                // TODO
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarı ile tamamlandı");
            }
        }
    }
}
