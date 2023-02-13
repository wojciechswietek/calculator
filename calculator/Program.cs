int add(int x, int y)
{
    return x + y;
}

int sub(int x, int y)
{
    return x - y;
}

int mul(int x, int y)
{
    return x * y;
}

int div(int x, int y)
{
    return x / y;
}

int? calculate(int firstNumber, int secondNumber, string mathOperation)
{
    if (mathOperation == "+")
    {
        return add(firstNumber, secondNumber);
    }

    if (mathOperation == "-")
    {
        return sub(firstNumber, secondNumber);
    }

    if (mathOperation == "*")
    {
        return mul(firstNumber, secondNumber);
    }

    if (mathOperation == "/")
    {
        return div(firstNumber, secondNumber);
    }

    return null;
}

void main()
{
    Console.WriteLine("Calculator");

    Console.WriteLine("Enter first number:");
    var firstInput = Console.ReadLine();
    int firstNumber = int.Parse(firstInput);

    Console.WriteLine("Enter second number:");
    var secondInput = Console.ReadLine();
    int secondNumber = int.Parse(secondInput);

    Console.WriteLine("Which function You want to use?");
    string mathOperation = Console.ReadLine();

    var result = calculate(firstNumber, secondNumber, mathOperation);
    Console.WriteLine($"Result:{result}");
}

main();