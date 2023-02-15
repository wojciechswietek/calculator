int add(int x, int y) => x + y;

int sub(int x, int y) => x - y;

int mul(int x, int y) => x * y;

int div(int x, int y) => x / y;

int? calculate(int firstNumber, int secondNumber, string mathOperation)
{
    int? result;
    switch (mathOperation)
    {
        case "+":
            result = add(firstNumber, secondNumber);
            break;

        case "-":
            result = sub(firstNumber, secondNumber);
            break;

        case "*":
            result = mul(firstNumber, secondNumber);
            break;

        case "/":
            result = div(firstNumber, secondNumber);
            break;

        default:
            result = null;
            break;
    }
    return result;
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