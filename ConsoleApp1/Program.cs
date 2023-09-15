using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Lab0
    {
        // Use methods get and validate the users input.
        internal static int Validate() 
        {
            bool isValid = true;
            while (isValid)
            {
                isValid = int.TryParse(Console.ReadLine(), out int ans);
                if (isValid)
                {
                    return ans;
                }
                Console.WriteLine("Please enter a valid number: ");
                isValid = true;
            }
            return 0;
        }

        internal static bool isPrime(int x)
        {
            for (int y = x - 1; y > 1; y--)
            {
                if (x % y == 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            /* Creating Variables
            Looping and Input Validation */
            int low = -1;
            int high = 0;
            while (low <= 0)
            {
                Console.WriteLine("Please enter a smaller number: ");
                low = Validate();
            }
            while (high < low)
            {
                Console.WriteLine("Please enter a larger number: ");
                high = Validate();
            }
            int diff = high - low;
            Console.WriteLine("The calculated difference is: " + (diff));

            // Using Arrays and File I/O
            int[] arrayDiff = new int[diff -1];
            for (int i = 0, j= low+1; j < high; i++, j++ ) 
            {
                arrayDiff[i] = j;
            }
            StreamWriter streamWriter = File.CreateText("data.txt");
            for (int i = diff -2 ; i >= 0; i--)
            {
                streamWriter.WriteLine(arrayDiff[i]);
            }
            streamWriter.Close();

            // Read the numbers back from the file and print out the sum of the numbers.
            Console.Write("The sum of reversed File I/O: ");
            int sum = 0;
            foreach (string line in File.ReadLines("data.txt")) 
            {
                sum += Convert.ToInt32(line);
            }
            Console.WriteLine(sum);

            /* Use a List instead of an array variable to store the numbers.
            Use the double data type instead of the int data type. 
            Print out the prime numbers between low and high */
            List<double> listDiff = new List<double>();
            foreach (int i in arrayDiff)
            {
                listDiff.Add((double)i);
                if (isPrime(i)) 
                {
                    Console.WriteLine("The Prime number is: " + (i));
                }
            }



        }
    }
}