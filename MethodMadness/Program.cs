using System;
using static System.Console;

namespace MethodMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numArray = { 5, 6.5, 12, 3, 10, 35 };
            double num = 23;

            printArray(numArray);
            printNumber(num);
            printNumberDouble(num);
            printNumber(num);
            Square(num); // squares the number but doesn' modify anything
            printNumber(num);
            num = Square(num); //changing num to be the square of itself
            printNumber(num);

            addOne(numArray);

            printArray(numArray);
            addOneCopy(numArray);
            printArray(numArray);

            if(IsEven(numArray.Length))
            {
                printArray(numArray);

                while(!IsEvenandSumOver100(numArray.Length, numArray))
                {
                    addOne(numArray); //adds one to array until sum is greater than 100
                }
                WriteLine("Sum is now > 100");
                printArray(numArray);
            }
            else
            {
                WriteLine("array is not of an even length");
            }

        }

        private static void printArray(double[] someArray)
        {
            for(int x = 0; x < someArray.Length; ++x)
            {
                WriteLine(someArray[x]);
            }
        }

        private static void printNumber(double aNumber)
        {
            WriteLine("The number is {0}", aNumber);
        }


        //prints out number multiplied by 2, does not change the original
        private static void printNumberDouble(double fred)
        {
            fred *= 2;
            WriteLine("The number doubled is {0}", fred);
        }

        //adds one to array, b/c arrays pass a reference this modifies the original array
        private static void addOne(double[] anneArray)
        {
            for(int i = 0; i < anneArray.Length; ++i)
            {
                anneArray[i] += 1;
            }

            WriteLine("Added 1.0 to array");
        }

        //adds one to a copy of the array, not changing the original
        private static void addOneCopy(double[] anneArray)
        {
            double[] copyArray = new double[anneArray.Length];
            anneArray.CopyTo(copyArray, 0);
            for (int i = 0; i < anneArray.Length; ++i)
            {
                copyArray[i] += 1;
            }

            
            WriteLine("Added 1.0 to copy of array");
            printArray(copyArray);
            WriteLine("*************************************");
        }

        //returns a number squared
        private static double Square(double aDoub)
        {
            double square = aDoub * aDoub;
            WriteLine("Power of Squares!");
            return square;
        }

        //tells if a number is even or not
        private static bool IsEven(int someInt)
        {
            if(someInt%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //tells if number is even and the sum of the array is greater than 100
        private static bool IsEvenandSumOver100(int someInt, double[] someArray)
        {
            if (someInt % 2 == 0)
            {
                if(SumOfArray(someArray) > 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //sums up the elements of an array and returns them
        private static double SumOfArray(double[] someArray)
        {
            double sum = 0;
            for(int i = 0; i < someArray.Length;++i)
            {
                sum += someArray[i];
            }

            return sum;
        }
    }
}
