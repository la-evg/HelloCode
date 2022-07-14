int[] array = { 1, 5, 6, 8, 7, 4, 12, 6, 9, 8 };
int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}