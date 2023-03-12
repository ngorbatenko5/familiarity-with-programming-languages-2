Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit (int result)
{
    while (result > 999)
    {
    result /= 10;
    }
    return result % 10;
}
bool ValidateNumber(int result)
{
    if (result < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
if (ValidateNumber(number))
{
    Console.WriteLine(ThirdDigit(number));
}

