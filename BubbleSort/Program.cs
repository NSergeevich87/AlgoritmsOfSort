

/// <summary>
/// Сортировка методом пузырька (Базовая)
/// </summary>
/// <param name="collection">Исходный массив</param>
/// <returns>Отсортированный массив массив</returns>
int[] SortBubble(int[] collection)
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

/// <summary>
/// Сортировка методом пузырька (Оптимизированная)
/// </summary>
/// <param name="collection">Исходный массив</param>
/// <returns>Отсортированный массив массив</returns>
int[] SortBubbleOptimized(int[] collection)
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
int[] mySelectionArray = SortBubble(array);
PrintArray(mySelectionArray);
System.Console.WriteLine();
System.Console.WriteLine();
array = NewArray(20);
PrintArray(array);
System.Console.WriteLine();
mySelectionArray = SortBubbleOptimized(array);
PrintArray(mySelectionArray);