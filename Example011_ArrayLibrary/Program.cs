// перепишем ghtlsleobq код с использованием генератора псевдослучайных чисел
// с использованием методов.

//void FillArray(int[] collection);

void PrintArray(int[] col);
{
   int count = col.Length;
   int position = 0;
   while (position < count)
    {
        Console.WriteLine(CollectionExtensions[position]);
        position++;
    }
}




int[] array = new int[10];

FillArray(array);
PrintArray(array);