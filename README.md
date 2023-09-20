# CalcTests
Testing the speed of various operations. Speeds based on 80,000 calculations performed

## Integer Addition vs. Integer Multiplication speed
There was a bit of fluctuation, but I was typically getting a ratio (Addition ticks / Multiplication ticks) of around 1.25.
So on average, that means that integer addition takes about 25% longer than integer multiplication.

## Squaring via Multiplication vs. Math.Pow Function
For a ratio (Multiplication ticks / Math.Pow ticks), I was consistently getting about 0.18.
So on average, squaring via multiplication only takes about 18% of the time that it takes to square via the Math.Pow function.
I'm assuming this is because of the extra time required to call the Math.Pow function versus just performing the calculation through a quick multiplication.
