int [] array = {1,426,739,1,56,9,7,1};

int n = array.Length;
int find = 1;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;//заканчивает поиск на первом элементе
    }
    index++;
}

