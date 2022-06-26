namespace TheChallenge
{
    public class Fibonacci
    {
       public static int PrintNthFibonacci(int number)
        {
            int[] fibonacciNumbers = new int[] { 0, 1 }; 
            int counter = 3;

            while (counter <= number)
            {
                int nextFibonacci = fibonacciNumbers[0] + fibonacciNumbers[1];

                fibonacciNumbers[0] = fibonacciNumbers[1];

                fibonacciNumbers[1] = nextFibonacci;

                counter += 1;
            }

            return number > 1 ? fibonacciNumbers[1] : fibonacciNumbers[0];
        }
    }
}

//Tech Training Bootcamp UK

//{ 0, 1, 1, 2, 3, 5, 8, 13, 21 }

// n = 5;
// return = 3
