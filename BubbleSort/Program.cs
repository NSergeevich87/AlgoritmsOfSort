System.Console.Clear();

// Сортировка методом пузырька (Базовая)

int[] SortBubble(ref int[] collection)
{
    int size = collection.Length;

    for (int current = 0; current < size - 1; current++)
    {
        for (int i = 0; i < size - 1; i++)
        {
            if (collection[i] > collection[i + 1])
            {
                int temp = collection[i];
                collection[i] = collection[i + 1];
                collection[i + 1] = temp;
            }
        }
    }

    return collection;
}


// Сортировка методом пузырька (Оптимизированная)

int[] SortBubbleOptimized(ref int[] collection)
{
    int size = collection.Length;

    for (int current = 0; current < size - 1; current++)
    {
        for (int i = 0; i < size - 1 - current; i++)
        {
            if (collection[i] > collection[i + 1])
            {
                int temp = collection[i];
                collection[i] = collection[i + 1];
                collection[i + 1] = temp;
            }
        }
    }
    return collection;
}

void CheckSort(int[] array)
{
    bool status = true;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            status = false;
            break;
        }
    }

    System.Console.WriteLine(status);
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
CheckSort(array);
System.Console.WriteLine();
int[] mySelectionArray = SortBubble(ref array);
PrintArray(mySelectionArray);
System.Console.WriteLine();
CheckSort(mySelectionArray);
System.Console.WriteLine();

System.Console.WriteLine();
array = NewArray(20);
PrintArray(array);
System.Console.WriteLine();
CheckSort(array);
System.Console.WriteLine();
mySelectionArray = SortBubbleOptimized(ref array);
PrintArray(mySelectionArray);
System.Console.WriteLine();
CheckSort(mySelectionArray);