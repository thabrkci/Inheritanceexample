namespace Inheritance_example;

class Program
{
    static void Main(string[] args)
    /*Aşağıda instance ile araçların marka model renk seçeneği ve teker sayısını yazdırdık.*/
    {
       Honda honda = new();
       Console.WriteLine(honda.standardcolour().ToString());//Enum döndüğü ve enumun kendi ifadesini aldığı için ToString kullandık.
       Console.WriteLine(honda.brand().ToString());//Aynı şekilde brand yani markada enumdan alındığı için ve string bir ifade olduğu için kullandık.
       Console.WriteLine(honda.wheel());//Tekerlek sayısı string ifade olmadığı için kullanmadık.
       

       Toyota toyota = new();
       Console.WriteLine(toyota.standardcolour().ToString());
       Console.WriteLine(toyota.brand().ToString());
       Console.WriteLine(toyota.wheel());
        
    }
}
