using System.Linq;

namespace Tutorial
{
    class Program
    {
        static string MyMethod(string name)
        {
            return "olá" + name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod("pedro"));
        }
    }
}