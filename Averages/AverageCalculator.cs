namespace Averages;

public static class AverageCalculator 
{
    public static double ArithmeticMean(string[] inputs)
    {
        var inputIntegers = inputs.Select(n => Int64.Parse(n));
        return inputIntegers.Average();
    }

}