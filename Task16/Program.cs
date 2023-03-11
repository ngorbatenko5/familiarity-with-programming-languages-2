Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(number1, number2) ? "ДА" : "Нет");

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
