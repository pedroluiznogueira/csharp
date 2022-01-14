namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit casting
            int myInt = 2;
            double myIntAsDouble = myInt;

            Console.WriteLine(myIntAsDouble);

            // explicit casting
            double myDouble = 1.0;
            int myDoubleAsInt = (int) myDouble;
            
            Console.WriteLine(myDoubleAsInt);
        }
    }
}