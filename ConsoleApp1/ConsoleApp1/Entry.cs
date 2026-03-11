namespace ConsoleApp1;

public class Entry : IExtractable
{
    private int power;
    private int speed;

    public Entry(int power, int speed)
    {
        this.power = power;
        this.speed = speed;
    }

    public int ExtractPower()
    {
        Console.WriteLine($"Power: {this.power}");
        return this.power;
    }

    public int ExtractSpeed()
    {
        Console.WriteLine($"Power: {this.power}");
        return this.power;
    }

    public int[] formatToArray()
    {
        return new int[] { this.power, this.speed };
    }
}