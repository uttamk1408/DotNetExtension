// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CalculateClass objCC = new CalculateClass();
int i = 5;
int j = 10;

objCC.Add(i, j);
objCC.Multiply(i, j);


public partial class CalculateClass
{
    public void Add(int i, int j)
    {
        Console.WriteLine("Total: " + i + j);
    }
}

public partial class CalculateClass
{
    public void Multiply(int i, int j)
    {
        Console.WriteLine("Total: " + i * j);
    }
}