var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

int buffValue;

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 1; j < arr.Length; j++)
    {
        if (arr[j-1] > arr[j])
        {
            buffValue = arr[j];
            arr[j] = arr[j-1];
            arr[j-1] = buffValue;
        }    
    }
}

foreach(var i in arr)
    Console.Write(i + " ");

Console.ReadKey();