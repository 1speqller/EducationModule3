static int[] GetArrayFromConsole()
{
    var result = new int[5];

    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}

static int[] ReturnSortArray(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
    return array;
}

static void ShowArray(int[] array, bool IsSort = false) 
{
    if (IsSort)
    {
        foreach (int i in ReturnSortArray(array))
        {
            Console.Write(i + " ");
        }
    }
    else
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
    }
}

ShowArray(GetArrayFromConsole(), true);