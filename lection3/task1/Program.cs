//Вид1
// void Metod1()
// {
//     Console.WriteLine("Автор");
// }

// Metod1();

//Вид2
// void Metod2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Metod2("Текст сообщения");

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Metod21("Текст", 4);
// Metod21(count: 4, msg: "Новый текст");


//Вид3
// int Metod3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Metod3();
// Console.WriteLine(Year);

//Вид 4
string Metod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Metod4(10, "asdf");
Console.WriteLine(res);