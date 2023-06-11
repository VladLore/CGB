Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    Console.Write("Наибольшее число " +num1);
}
else if (num2>num1)
{
    Console.Write("Наибольшее число "+num2);
}