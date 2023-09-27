using System;
using System.Diagnostics;
using System.Globalization;

class CalcTests
{
    static void Main()
    {
        int n = 80000;      //Determines the number of calculations to be performed

        int[,] numbers;       //Creates an array to hold the random numbers
        double[,] doubleNumbers;        //Creates an array to hold random doubles

        Stopwatch timer = new Stopwatch();        //Initializes the timer

        numbers = GenRanNumbers(n);     //Fill our arrays with random numbers
        doubleNumbers = GenRanDoubleNumbers(n);

        timer.Start();
        AddNums(numbers, n);        //Perform the adding operation and time it
        timer.Stop();
        
        Console.WriteLine("Integer Additions:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer addition
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float addTicks = timer.ElapsedTicks; 




        timer.Restart(); 
        MultNums(numbers, n);       //Perform the multiplying operation and time it
        timer.Stop();

        Console.WriteLine("\nInteger Multiplication:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer multiplication
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float multTicks = timer.ElapsedTicks;


        //Find the ration of adding vs. multiplying and display it
        float ratio = addTicks / multTicks;
        
        Console.WriteLine("\nRatio (Add vs. Mult):");
        Console.WriteLine(ratio);

        timer.Restart();
        AddDoubles(doubleNumbers, n);        //Perform the adding operation and time it
        timer.Stop();
        
        Console.WriteLine("\nDouble Additions:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer addition
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float addDoubleTicks = timer.ElapsedTicks; 




        timer.Restart(); 
        MultDoubles(doubleNumbers, n);       //Perform the multiplying operation and time it
        timer.Stop();

        Console.WriteLine("\nDouble Multiplication:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for integer multiplication
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float multDoubleTicks = timer.ElapsedTicks;


        //Find the ration of adding vs. multiplying and display it
        float Doubleratio = addDoubleTicks / multDoubleTicks;
        
        Console.WriteLine("\nRatio (Add Doubles vs. Mult Doubles):");
        Console.WriteLine(Doubleratio);



        timer.Restart();
        SquareMult(numbers, n);     //Square the first row of numbers by multiplying them by themselves and time it
        timer.Stop();

        Console.WriteLine("\n \nSquare by Multiplication:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for squaring by multiplication
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float squareMultTicks = timer.ElapsedTicks;


        timer.Restart();
        SquareNums(numbers, n);     //Square the first row of numbers using math pow function and time it
        timer.Stop();

        Console.WriteLine("\nSquare with Math.Pow:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for squaring by math pow function
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float squareTicks = timer.ElapsedTicks;


        //Find the ratio of squaring by multiplying vs. math pow function and display it
        float squareRatio = squareMultTicks / squareTicks;
        Console.WriteLine("\nRatio (Mult vs. Math.Pow:)");
        Console.WriteLine(squareRatio);



        timer.Restart();
        SquareRootNums(numbers, n);     //Square the first row of numbers using math pow function and time it
        timer.Stop();

        Console.WriteLine("\nSquare Root with Math.Sqrt:");
        Console.WriteLine(timer.ElapsedMilliseconds + " ms");       //Display the time it took for squaring by math pow function
        Console.WriteLine(timer.ElapsedTicks + " ticks");
        float squareRootTicks = timer.ElapsedTicks;


        //Find the ratio of square root vs. square by multiplication and display it
        float squareRootRatio = squareRootTicks / squareMultTicks;
        Console.WriteLine("\nRatio (Square Root vs. Square Mult:)");
        Console.WriteLine(squareRootRatio);

        //Find the ratio of square root vs. square by pow function and display it
        float squareRootvPowRatio = squareRootTicks / squareTicks;
        Console.WriteLine("\nRatio (Square Root vs. Square by pow function:)");
        Console.WriteLine(squareRootvPowRatio);


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


        //Function that generates an array of random doubles
        static double[,] GenRanDoubleNumbers(int count)
    {
        Random rand = new Random();      // instantiate random number generator
        double[,] num = new double[count,3]; // make array


        //Fill in the elements of the array
        for(int i = 0; i < count; i++)
        {
            num[i,0] = rand.NextDouble();
            num[i,1] = rand.NextDouble();
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


    //Function that adds two doubles
    static void AddDoubles(double[,] nums, int count)
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
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }


    //Function that multiplies two doubles
    static void MultDoubles(double[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }


    //Function that squares by multiplication
    static void SquareMult(int[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = nums[i,0]*nums[i,0];
        }
    }


    //Function that squares using the pow function
    static void SquareNums(int[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = (int)Math.Pow(nums[i,0], 2);
        }
    }


    //Function that gets the square roots using the sqrt function
    static void SquareRootNums(int[,] nums, int count)
    {
        for (int i = 0; i < count; i++)
        {
            nums[i,2] = (int)Math.Sqrt(nums[i,0]);
        }
    }
}
