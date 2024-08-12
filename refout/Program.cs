using System;
using System.Threading.Channels;


namespace refout {
    
    class Program
    {
        //değer tiplerini metoda değişken olarak gönderdiğimizde kopyası gönderilir.Bu durumda, metodun içinde yapılan değişiklikler orijinal değeri etkilemez. Ancak ref anahtar kelimesi kullanıldığında, değişkenin kendisi metoda gönderilir. Böylece, metodun içinde yapılan değişiklikler orijinal değeri doğrudan etkiler
        //Ref örneği 
        //Özet
        //ref olmadan: Değişkenin bir kopyası gönderilir, orijinal değer değişmez.
        //ref ile: Değişkenin kendisi gönderilir, orijinal değer değişir.
        static int Topla(int sayi1, int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }

        static void Main(string[] args)
        {
            //refout
            int sayi1 = 10;
            int sayi2 = 20;
            int result = Topla(sayi1, sayi2);
            Console.WriteLine(sayi1);
            Console.WriteLine(result);

            //out
            int sayi3;
            int sayi4 = 20;
            int result2 = Topla2(out sayi3, sayi4);
            Console.WriteLine(result2);
        }


        //Out örneği
        //out anahtar kelimesi, bir metodun dışarıya bir veya birden fazla değeri döndürmesi gerektiğinde kullanılır. out parametreleri, metodun içinde mutlaka bir değer atanması gereken ve metodun dışında kullanılacak olan parametrelerdir.
        static int Topla2(out int sayi3, int sayi4)
        {
            sayi3 = 30;
            return sayi3 + sayi4;
        }
    }
}

