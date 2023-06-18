void FillArray(int[] collction)
{
    int length = collction.Length;
    int index = 0;
    while (index < length)
    {
        collction[index] = new Random().Next(1,10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int [] array = new int [10];

FillArray(array);
PrintArray(array);