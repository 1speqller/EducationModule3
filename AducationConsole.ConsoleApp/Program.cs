static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
    sorteddesc = SortArrayDesc(array);
    sortedasc = SortArrayAsc(array);
}

static int[] SortArrayDesc(int[] array)
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

static int[] SortArrayAsc(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
    return array;
}