namespace Averages.Tests;

[TestClass]
public class WhenCalculatingAverages
{
    [TestMethod]
    public void AverageOfOneNumberIsItself()
    {
        string[] inputs = { "2" };
        double average = AverageCalculator.ArithmenticMean(inputs);
        Assert.AreEqual(2, average, 1E-14);
    }

    [TestMethod]
    public void AverageOfSeveralNumbersIsAsExpected() {
        string[] inputs = { "1", "2", "3" };
        double average = AverageCalculator.ArithmenticMean(inputs);
        Assert.AreEqual(2, average, 1E-14);
    }
}