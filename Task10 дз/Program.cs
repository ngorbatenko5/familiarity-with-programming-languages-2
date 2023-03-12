Console.WriteLine("Введите трёзначное число");
int result = Convert.ToInt32(Console.ReadLine());

if (result < 100 || result >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
    return;
}

int secondDigit = result / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа {secondDigit}");


