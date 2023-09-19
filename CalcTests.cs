using System;
using System.Diagnostics;

class CalcTests
{
    static void Main()
    {
        int n = 5;      //Determines the number of calculations to be performed

        int[,] numbers;       //Creates an array to hold the random numbers
        Stopwatch timer = new Stopwatch();        //Initializes the timer

        numbers = GenRanNumbers(n);     //Fill our array with random numbers

        for (int i = 0; i < n; i++)
        {
                Console.WriteLine(numbers[i,0] + "              " + numbers[i,1]);
        }

        

    }


    //Function that generates an array of random numbers
    static int[,] GenRanNumbers(int count)
    {
        Random rand = new Random();      // instantiate random number generator
        int[,] num = new int[count,3]; // make array


        //Fill in the elements of the array
        for(int i = 0; i < count; i++)
        {
            num[i,0] = rand.Next();
            num[i,1] = rand.Next();
        }

        return num;
    }

}
