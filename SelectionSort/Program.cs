int[] SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    return collection;
}

int[] MySortSelection(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int pos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[pos]) pos = j;
        }

        int temp = array[i];
        array[i] = array[pos];
        array[pos] = temp;
    }
    return array;
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
//int[] selectionArray = SortSelection(array);
//PrintArray(selectionArray);
//System.Console.WriteLine();
int[] mySelectionArray = MySortSelection(array);
PrintArray(mySelectionArray);