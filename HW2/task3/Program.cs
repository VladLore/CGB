Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number<=5)
{
    Console.WriteLine("Будний день");
}
else if (number==7 ^ number==6)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Такого дня нет");
}