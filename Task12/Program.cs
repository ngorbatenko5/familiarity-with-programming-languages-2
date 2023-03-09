Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int remains = number1 % number2;
Console.WriteLine(remains == 0? "кратно":$"не кратно, остаток {remains}");
