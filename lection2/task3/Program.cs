int [] array = {11,25,38,47,52,69,75,84};

int n = array.Length;


int find = 47;

int index = 0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index +1;
    index++;
}