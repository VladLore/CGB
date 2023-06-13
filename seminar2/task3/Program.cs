bool IsMiltiple(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsMiltiple(number))
{
    Console.Write("Да");
}
else
{
   Console.Write("нет"); 
}