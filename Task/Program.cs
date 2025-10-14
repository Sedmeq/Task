
class Program
{
    //Task 1
    static double Area(double r)
    {
        double p = 3;
        return p * r * r;
    }
    static double Area(double a, double b)
    {
        return a * b;
    }
    static double Area(double a, double b, double c)
    {
        return 2 * (a * b + a * c + b * c);
    }
    static double Area(double a, double b, double c, double r)
    {
        double p = (a + b + c) / 2;
        return p * r;
    }

    //Task 2
    static int newMethod(int a)
    {
        return a * a;
    }
    static double newMethod(int a, int b)
    {
        return Math.Pow(a, b);
    }
    static void Main()
    {
        Console.WriteLine("Task 1");
        Console.WriteLine(Area(5));
        Console.WriteLine(Area(5, 10));
        Console.WriteLine(Area(5, 10, 15));
        Console.WriteLine(Area(5, 10, 15, 20));

        Console.WriteLine("Task 2");
        Console.WriteLine(newMethod(5));
        Console.WriteLine(newMethod(5, 3));
    }
}
