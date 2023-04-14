int[] SortQuick(int[] collection, int left, int right)
{
    int i = left;
    int j = right;

    int pivot = collection[Random.Shared.Next(left, right)];
    while (i <= j)
    {
        while (collection[i] < pivot) i++;
        while (collection[j] > pivot) j--;

        if (i <= j)
        {
            int t = collection[i];
            collection[i] = collection[j];
            collection[j] = t;
            i++;
            j--;
        }
    }
    if (i < right) SortQuick(collection, i, right);
    if (left < j) SortQuick(collection, left, j);
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
int[] mySelectionArray = SortQuick(array, 0, array.Length - 1);
PrintArray(mySelectionArray);