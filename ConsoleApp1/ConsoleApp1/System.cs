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
        
        Console.WriteLine($"Average: {calculateAverage(input.formatToArray())}"); //jejku co za głuptasek tutaj popełnił błąd, powinniśmy użyć git blame żeby go znaleźć i zabić
        Console.WriteLine($"Discrepency: {calculateMax(input.formatToArray()) - calculateMin(input.formatToArray())}");
    }

    public double calculateAverage(int[] values)
    {
        return values.Average();
    }

    public int calculateMax(int[] values)
    {
        return values.Max();
    }
    public int calculateMin(int[] values)
        {
            return values.Min();
        }

}