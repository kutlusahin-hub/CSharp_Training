using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
            // 2.4.6.8 --> Dizi
            // sarı,kırmızı,mavi,turuncu,beyaz --> Dizi
            // samsun,ankara,istanbul,izmir --> Dizi
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";  // Diziler 0.index (indis, eleman)'ten başlar.
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[6]); // Değer ataması yapmadığımız index konsolda 0 olarak çıkar.

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]); // 2.index yani baştan üçüncü eleman. (0.index prag, 1.index roma, 2.index atina...)

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i=0; i<colors.Length; i++) // 0.indexten başlayacak 6.indexe kadar gidecek
            //{                                  // colors.length == 7 eleman
            //    Console.WriteLine(colors[i]);
            //} 

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for(int i=0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber=myArray[0];
            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);  // 6 eleman --> çıktısı 6

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); // Dizideki elemanları küçükten büyüğe sıralar.
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); // Dizideki elemanları sondan başa doğru sıralar.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); 
            //Array.Reverse(numbers); // Sort + Reverse --> Büyükten küçüğe sıralar.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");  // yazılan elemanın kaçıncı index olduğunu belirtir.
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max()  // Dizideki en büyük elemanı yazdırır.
            //    + " - Dizinin en küçük elemanı: " + numbers.Min()); // Dizideki en küçük elemanı yazdırır.



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: "); // $ sembolü, bir çift tırnak içerisinde parametresel ifadeleri-
            //                                                       // - kullanmak için olanak sağlar.
            //    cities[i]= Console.ReadLine();                     // Çift tırnak bütünlüğünü bozmaz, kolaylık sağlar.
            //}                                                      // Çift tırnak içerisinde olmasına rağmen {i + 1} değil,-
            //                                                       // - {i + 1}'e karşılık gelen değeri yazdırır.
            //Console.WriteLine();
            //Console.WriteLine("-------------------");

            //for(int i=0; i<cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    sum += numbers[i];  // dizideki elemanları topladı.
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            //Console.WriteLine("Çift sayılar");
            //Console.WriteLine();

            //for(int i=0;  i<numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
