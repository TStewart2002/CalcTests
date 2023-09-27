# CalcTests
Testing the speed of various operations. Speeds based on 800,000 calculations performed

## Integer Addition vs. Integer Multiplication speed
There was a bit of fluctuation, but I was typically getting a ratio (Addition ticks / Multiplication ticks) of around 1.25.
So on average, that means that integer addition takes about 25% longer than integer multiplication.

## Double Addition vs. Double Multiplication speed
There was a lot of fluctuation, but the tests averaged out to a ratio (Addition ticks / Multiplication ticks) of 1.39.
So on average, that means that double addition takes about 40% longer than double multiplication.

## Squaring via Multiplication vs. Math.Pow Function
For a ratio (Multiplication ticks / Math.Pow ticks), I was consistently getting about 0.18.
So on average, squaring via multiplication only takes about 18% of the time that it takes to square via the Math.Pow function.
I'm assuming this is because of the extra time required to call the Math.Pow function versus just performing the calculation through a quick multiplication.

## Math.Sqrt function vs. Square by multiplying and Math.Pow function
For a ratio (Math.Sqrt ticks / Square via mult ticks), I got an average of 1.03.
So on average, finding the square root of a set of numbers, and finding square via multiplication, take about the same amount of time.

For a ratio (Math.Sqrt ticks / Math.Pow ticks), I got an average of 0.24.
So on average, finding the square root of a set of numbers is a whole lot faster than finding the square via the pow function.
