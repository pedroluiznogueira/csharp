using System.Linq;
using Tutorial.model;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Car pedro = new Car();

            // if you assign to object.Property you are using setter
            pedro.Name = "pedro";
            // if you access object.Property you are using getter
            Console.WriteLine(pedro.Name);

            // if you assign to object.Property you are using setter
            pedro.Fullname = "pedro luiz nogueira mendes";
            // if you access object.Property you are using getter
            Console.WriteLine(pedro.Fullname);
        }
    }
}