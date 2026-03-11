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
    }
}