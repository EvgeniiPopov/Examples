int[] array = { 1, 51, 3, 4, 5, 6, 7, 8, 41 };

int n = array.Length;
int find = 41;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        
    }
    // index = index + 1;
    index++;

}



