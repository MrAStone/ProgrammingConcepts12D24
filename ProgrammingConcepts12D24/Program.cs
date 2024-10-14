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

            //for(int i = 1; i < 10; i --)
            //{
            //    //Console.WriteLine(i);
            //    if (i ==int.MinValue)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.WriteLine("END");
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1;j<=3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            // Indefinite / Condition Controlled iteration
            int x = 0;
            while (x < 10)
            {
                x++;
            }
            Console.WriteLine(x);
            string userGuess = "";
            while(userGuess != "a")
            {
                Console.Write("Enter a guess: ");
                userGuess = Console.ReadLine();
            }
            //x = 10 (from previous loop)
            do
            {
                x++;
            } while (x < 10);
            Console.WriteLine(x); //x = 11
            while(x < 10)
            {
                x++ ;
            }
            Console.WriteLine(x);// x still = 11 
            while (x > 10)
            {
                x++;
            }
            x = 11;
            Console.WriteLine(x);
            //while (x == 11)
            //{
            //    Console.WriteLine(x);
            //}

            // Selection
            int userGuessNumber;
            Console.Write("Enter a whole number: ");
            userGuessNumber = Convert.ToInt32(Console.ReadLine());
            if (userGuessNumber == 7)
            {
                Console.WriteLine("You guessed 7");
            }else
            {
                Console.WriteLine("You didn't guess 7");
            }

            if (userGuessNumber == 8)
            {
                Console.WriteLine("You guessed 8");
            }else if(userGuessNumber < 8)
            {
                Console.WriteLine("You guessed less than 8");
            }
            else
            {
                Console.WriteLine("You guessed more than 8");
            }

            bool iAmTrueOrFalse = true;
            while (iAmTrueOrFalse)
            {
                iAmTrueOrFalse = false;
            }
        }
    }
}
