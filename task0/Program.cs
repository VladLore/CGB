// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int quater = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {quater}");

Console.WriteLine("Введите первое яисло");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int two = Convert.ToInt32(Console.ReadLine());
if (first*first==two) 
Console.WriteLine("Второе число, явялется квадратом первого");
else 
Console.WriteLine("Первое число не явялется квадратом второго");

Console.WriteLine("Введите число от 1 до 7");
int user = Convert.ToInt32(Console.ReadLine());

if (user==1)
Console.WriteLine("Понедельник");
else if (user == 2)
Console.WriteLine("Вторник");