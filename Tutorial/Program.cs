namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring and assigning
            int myNum = 5;

            // declaring without assigning
            string myText;
            myText = "pedro";

            char first = 'p', second = 'l'; 

            // constant
            const string noChange = "luiz";

            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;

            Console.WriteLine(myNum);
            Console.WriteLine(myText);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(noChange);    
        }
    }
}