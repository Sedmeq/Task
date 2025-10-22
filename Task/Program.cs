
using Task;
using Task.String___Array_Methods;

class Program
{
    static void Main(string[] args)
    {
        //MethodTask.print();

        StringSubstringMethod strMethod = new StringSubstringMethod();
        string result = strMethod.customSubstring("Hello, World!", 7);
        Console.WriteLine(result);
        string result2 = strMethod.customSubstring("Hello, World!", 7, 5);
        Console.WriteLine(result2);

        StringContainsMethod stringContains = new StringContainsMethod();
        bool containsResult = stringContains.customContains("Hello, World!", "World");
        Console.WriteLine(containsResult);
        bool containsCharResult = stringContains.customContains("Hello, World!", 'H');
        Console.WriteLine(containsCharResult);

    }
}
