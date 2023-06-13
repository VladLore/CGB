bool IsMiltiple(int num)
{
    if (num % 2 == 0 && num % 3 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.Read());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (IsMiltiple(number))
{
    Console.Write("Да");
}
else
{
   Console.Write("нет"); 
}