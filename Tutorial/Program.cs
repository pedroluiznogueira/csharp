using System.Linq;

namespace Tutorial
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }

        // I just got executed!
        // I just got executed!
        // I just got executed!
    }
}