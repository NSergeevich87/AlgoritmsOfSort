int[] SortCounting(int[] collection)
{
    int size = collection.Length;

    int max = collection[0];
    for (int i = 1; i < size; i++)
        if (collection[i] > max) max = collection[i];

    int[] counter = new int[max + 1];

    for (int i = 0; i < size; i++)
        counter[collection[i]]++;
    Console.WriteLine($"counter = [{String.Join(' ', counter)}]");
    int index = 0;
    for (int i = 0; i < max + 1; i++)
        for (int j = 0; j < counter[i]; j++)
            collection[index++] = i;

    return collection;
}

int[] NewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] array = NewArray(20);
PrintArray(array);
System.Console.WriteLine();
int[] mySelectionArray = SortCounting(array);
PrintArray(mySelectionArray);