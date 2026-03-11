namespace ConsoleApp1;

public class System
{
    private Entry input;

    public System(Entry input)
    {
        this.input = input;
    }

    public void readInput()
    {
        input.ExtractPower();
        input.ExtractSpeed();
        Console.WriteLine($"Power: {calculateAverage(input.formatToArray())}");
    }

    public double calculateAverage(int[] values)
    {
        return values.Average();
    }

}