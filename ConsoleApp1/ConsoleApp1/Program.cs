class Program
{
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static double Sum(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        double result = Sum(7.9, 5.3);
        Console.WriteLine(result);
    }
}
