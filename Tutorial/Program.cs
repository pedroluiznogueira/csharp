using System.Linq;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pedro = new Person();

            // if you assign to object.Property you are using setter
            pedro.Name = "pedro luiz nogueira mendes";
            // if you access object.Property you are using getter
            Console.WriteLine(pedro.Name);
        }
    }
}