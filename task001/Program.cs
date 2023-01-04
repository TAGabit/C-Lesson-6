// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
ReversArray1(ref array);
Console.WriteLine(string.Join(" ", array));

int[] GetArray(int size, int minValue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxvalue + 1);
    }
    return res;
}

void ReversArray1(ref int[] inArray)
{
    for(int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = k;
    }
}

int [] ReversArray2(ref int[] intArray)
{
    int[] result = new int[intArray.Length];
    for (int i = 0; i < intArray.Length; i++)
    {
        result[i] = intArray[intArray.Length - 1 -i];

    }
    return result;
}