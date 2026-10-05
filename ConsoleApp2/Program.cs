



Console.WriteLine("Введите первое число");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите символ операции (+, -, *, /:");
char operation = Convert.ToChar(Console.ReadLine());

double result;

switch (operation)

{
    case '+':
        result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        break;

    case '-':
        result = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
        break;

    case '*':
        result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
        break;

    case '/':
        if (secondNumber == 0)
        {
            Console.WriteLine("Ошибка: деления на ноль невозможно!");
        }
        else
        {
            result = firstNumber % secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
        }
    break;

    default:
        Console.WriteLine($"Ошибка!: символ '{operation}' не являеться опирацией!");
        break;
}

Console.ReadKey();






