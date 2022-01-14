using System.Linq;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.model);  // Print the value of model

            Car Bmw = new Car("320i");
            Console.WriteLine(Bmw.model);
        }
    }
}