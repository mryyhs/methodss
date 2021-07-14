using System;

namespace methodss
{
    class Program
    {
        static void Main(string[] args)
        {

            product product1 = new product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            product product2 = new product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "diyarbakır karpuzu";

            product[] products = new product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("-------------METOTLAR--------------");

            sepetManager sepetManager = new sepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.ekle2("armut","yeşil armut",15,5);
            sepetManager.ekle2("elma", "yeşil elma", 15,4);
            sepetManager.ekle2("erik", "yeşil erik", 15,3);

        }
    }
}
