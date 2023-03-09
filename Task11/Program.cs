int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000-> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;

// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine($"Результат {result}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Число без второй цифры {removeSecondDigit}");

int RemoveSecondDigit (int num) // num = number
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}