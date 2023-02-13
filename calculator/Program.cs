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

int? calculate(int firstNumber, int secondNumber, string mathOperation)
{
    int? result;
    if (mathOperation == "+")
    {
        result = add(firstNumber, secondNumber);
    }
    else if (mathOperation == "-")
    {
        result = sub(firstNumber, secondNumber);
    }
    else if (mathOperation == "*")
    {
        result = mul(firstNumber, secondNumber);
    }
    else if (mathOperation == "/")
    {
        result = div(firstNumber, secondNumber);
    }
    else
    {
        result = null;
    }
    return result;
}


void main()
{

    Console.WriteLine("Calculator");
    Console.WriteLine("Enter first number:");
    string firstInput = Console.ReadLine();
    int firstNumber = int.Parse(firstInput);
    Console.WriteLine("Enter second number:");
    string secondInput = Console.ReadLine();
    int secondNumber = int.Parse(secondInput);
    Console.WriteLine("Which function You want to use?");
    string mathOperation = Console.ReadLine();
    var result = calculate(firstNumber, secondNumber, mathOperation);
    Console.WriteLine("Result:", result);
}


main();