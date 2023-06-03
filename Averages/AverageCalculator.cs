namespace Averages;

public static class AverageCalculator 
{
    public static double ArithmeticMean(string[] inputs) => inputs.Select(n => Int64.Parse(n)).Average();
}