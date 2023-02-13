#region add function 

int add(int x, int y)
{
    return x + y;
}

#endregion

#region sub function
int sub(int x, int y)
{
    return x - y;
}

#endregion

#region mul function
int mul(int x, int y)
{
    return x * y;
}

#endregion

#region div function

int div(int x, int y)
{
    return x / y;
}

#endregion

void main()
{
    int a;
    int b;
    Console.WriteLine("Calculator");
    Console.WriteLine("Enter first number:");
    string A = Console.ReadLine();
    a = int.Parse(A);
    Console.WriteLine("Enter second number:");
    string B = Console.ReadLine();
    b = int.Parse(B);
    Console.WriteLine("Witch function You want to use?");
    string F = Console.ReadLine();

    int result;

    if (F == "+")
    {
        result = add(a, b);
        Console.WriteLine(result);

    }
    else if (F == "-")
    {
        result = sub(a, b);
        Console.WriteLine(result);

    }
    else if (F == "*")
    {
        result = mul(a, b);
        Console.WriteLine(result);

    }
    else if (F == "/")
    {
        result = div(a, b);
        Console.WriteLine(result);

    }
    else
    {
        Console.WriteLine("Wrong function");
    }
}


main();