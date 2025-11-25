using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları  
            // Yazılan Kodları bir klasör gibi içine alıp saklayabilir.

            // Console.WriteLine("Merhaba Dünya");  // "Line" İçerideki kelimeyi yazdırır, yazı imlecini alt satıra geçirir. 
            // Console.Write("Selam");  // Line olmadan içerideki kelime yazdırılır, imleç aynı satırdan devam eder.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine(); // Bir satır boşluk bırakır.
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion  // Saklanılacak kodların bitiş noktası.

            #region String Değişkenler

            // string
            // Değişken_türü değişken_adı;

            //string name;
            //name = "Kutlu";
            //Console.WriteLine(name); // Konsola "Kutlu" yazdırır.

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül"; // Programlamada hiyerarşik bir sistem vardır. Yukarıdan aşağıya doğru kodlar okunur.
            //                          // İlk "Ali", sonra "Ayşegül" yazılacaktır çünkü customerName adlı değişkeni artık değiştirdik.
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int, tam sayılar için kullanılır.
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("----- Kola: " + cokePrice + " TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("----- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("----- Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int pizzaCount;
            int lemonadeCount;
            int friesCount;
            int waterCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            int totalWaterPrice;
            int totalFriesPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;
            friesCount = 1;
            waterCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalWaterPrice = waterCount * waterPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();
            int totalPrice = totalCokePrice + totalFriesPrice + totalWaterPrice + totalPizzaPrice + totalHamburgerPrice
                + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read(); // Yazdırılmak istenen kelimeleri konsolda görünür kılar.           
        }
    }
}
