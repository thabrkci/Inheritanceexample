namespace Inheritance_example
{

    public class Toyota : IOtomobil
    {
        public Brand1 brand()
        {
           return Brand1.Toyota;//Toyota marka aracın enumdan alınan Brand1 enumu ile IOtomobil'deki metotla döndürdük(return)
        }

        public Standarcolour1 standardcolour()//Aynı şekilde fabrika çıkış standart rengini yukarıdaki gibi döndürdük
        {
            return Standarcolour1.Gray;
        }

        public int wheel()//Burada int olduğu için direkt olarak fabrika çıkışı 4 teker return yaptık herhang bir enum veya ekstra metot kullanmadık.
        {
            return 4;
        }
    }








}