using System;
using System.Diagnostics;
using System.Globalization;

class CalcTests
{
    static void Main()
    {
        int n = 5;      //Determines the number of calculations to be performed

        int[,] numbers;       //Creates an array to hold the random numbers
        Stopwatch timer = new Stopwatch();        //Initializes the timer

        numbers = GenRanNumbers(n);     //Fill our array with random numbers


        timer.Start();
        AddNums(numbers, n);        //Perform the adding operation and time it
        timer.Stop();
        
        Console.WriteLine("Integer Additions");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer addition
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float addTicks = timer.ElapsedTicks; 




        timer.Restart(); 
        timer.Start();
        MultNums(numbers, n);       //Perform the multiplying operation and time it
        timer.Stop();

        Console.WriteLine("\n \n");
        Console.WriteLine("Integer Multiplication");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer multiplication
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float multTicks = timer.ElapsedTicks;


        //Find the ration of adding vs. multiplying and display it
        float ratio = addTicks / multTicks;
        
        Console.WriteLine("\n \n");
        Console.WriteLine("Ratio (Add vs. Mult):");
        Console.WriteLine(ratio);


    }


    //Function that generates an array of random integers
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



    //Function that adds two integers
    static void AddNums(int[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }



    //Function that multiplies two integers
    static void MultNums(int[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = nums[i,0]*nums[i,1];
        }
    }
}
