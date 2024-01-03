namespace Inheritance_example
{

    public class Honda : IOtomobil
    {
        public Brand1 brand()
        {
            return Brand1.Honda; 
        }

        public Standarcolour1 standardcolour()
        {
            return Standarcolour1.Gray;
        }

        public int wheel()
        {
            return 4;
        }
    }






}