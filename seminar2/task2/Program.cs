bool OddEven(int numberA, int numberB)
{
    if (numberA%numberB==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(OddEven(numberA, numberB))
{
    System.Console.Write($"Число {numberB} кратно числу {numberA}");
}
else
{
    System.Console.Write($"Число {numberB} не кратно числу {numberA}, остаток {numberA % numberB}");
}