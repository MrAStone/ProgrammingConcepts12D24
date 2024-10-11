namespace ProgrammingConcepts12D24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            int aNumber = 3;
            // constant declaration
            const string aConstant = "Can't Change";
            // assignment
            aNumber = 42;
            Console.Write("Enter something: ");
            string aString = Console.ReadLine();

            // iteration
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 9;i>=0;i--)
            {
                Console.WriteLine(i);
            }

            for(int i = 1;i< 100; i += 10)
            {
                Console.WriteLine(i);
            }

            for(int i = 1; i < 10; i --)
            {
                //Console.WriteLine(i);
                if (i ==int.MinValue)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("END");
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1;j<=3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }
        }
    }
}
