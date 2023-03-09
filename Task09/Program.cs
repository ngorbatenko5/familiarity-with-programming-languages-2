int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа ровна {firstDigit}");
// else 
//     Console.WriteLine($"Наибольшая цифра числа ровна {secondDigit}");

int MaxDigit2 = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа ровна {MaxDigit2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}