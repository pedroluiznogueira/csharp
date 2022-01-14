namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            int timeee = 20;
            string result = (timeee < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}