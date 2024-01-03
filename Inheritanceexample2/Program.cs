/*Bu örnekte herhangi bir marka model telefon alırken yanında standart olarak gelen ekipmanları İnterface ile gösterdik
aşağı Apple,Samsung ve Redmi marka telefonların yanında gelen standart ekipmanları görüyoruz.
Ekrana yazdırma kısmında "ToString" Kullanmamızın nedeni Enumdan çağrılan bir değişken olduğu için.Akabinde garanti süresini yazdırırken herhangi bir dönüşüme uğramadı int değişkeni olduğu için.*/



namespace Inheritanceexample2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("||||||||Apple Phone Standart Equipment||||||||");
        
        Apple apple = new();
        Console.WriteLine(apple.warranty());
        Console.WriteLine(apple.charcingadapter().ToString());
        Console.WriteLine(apple.usbcablo().ToString());

        Console.WriteLine("||||||||Redmi Phone Standart Equipment||||||||");

        Redm redm = new();
        Console.WriteLine(redm.warranty());
        Console.WriteLine(redm.charcingadapter().ToString());
        Console.WriteLine(redm.usbcablo().ToString());

       Console.WriteLine("||||||||Samsung Phone Standart Equipment||||||||");

       Samsung samsung = new();
        Console.WriteLine(samsung.warranty());
        Console.WriteLine(samsung.charcingadapter().ToString());
        Console.WriteLine(samsung.usbcablo().ToString());
        
        
       
    }
}
