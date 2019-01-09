namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber, SecondNumber, Result, EnterNumber;

            FirstNumber = 1;
            SecondNumber = 1;

            System.Console.WriteLine
                ("          ==========================SHOW FIBONACCI==========================");

            System.Console.WriteLine();

            System.Console.Write("Please Enter Number: ");

            EnterNumber = System.Convert.ToInt32
                (System.Console.ReadLine());

            System.Console.WriteLine();
            
            System.Console.Write
                (FirstNumber+", " + SecondNumber+", ");

            for (int i = 0; i <= EnterNumber; i++)
            {
                Result = FirstNumber + SecondNumber;
                
                System.Console.Write(Result+", ");

                FirstNumber = SecondNumber;

                SecondNumber = Result;

            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            
            System.Console.Write("Please [ENTER] To EXIT... ");
            System.Console.Read();

        }
    }
}
