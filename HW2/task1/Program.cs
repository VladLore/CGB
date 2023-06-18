// Console.WriteLine("Введите трехзначное число ");
// string num = Console.ReadLine();
// int sec = Convert.ToInt32(num);
// Console.WriteLine(sec % 1000);

Console.WriteLine("Введите трехзначное число ");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine(number % 10);