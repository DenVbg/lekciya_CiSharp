int[] array = {11,21,31,4,15,61,17,18,19};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

 