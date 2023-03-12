Console.WriteLine("Введите число дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

bool Weekend(int Weekday)
{
    if (Weekday > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int result)
{
   if (result > 0 && result <= 7)
   {
    return true;
   }
   Console.WriteLine("Это не день недели");
   return false;
}

if (ValidateWeekday(number))
{
    if (Weekend(number))
    {
    Console.WriteLine("Выходной");
    }
    else
    {
    Console.WriteLine("Работаем дальше");
    }
}