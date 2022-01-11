// Второй варинат решения - длина второго массива подсчитывается во время создания первого и записывается как первый элемент массива

int[] CreateSourceArray(int size, int min, int max)
{
    int[] array = new int[size + 1];
    array[0] = 0;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        if (array[i] % 2 == 0) array[0]++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int[] GetEvenArray(int[] sourceArray)
{
    int[] newArray = new int[sourceArray[0] + 1];
    int j = 1;
    newArray[0] = 0;
    for (int i = 1; i < sourceArray.Length; i++)
    {
        if (sourceArray[i] % 2 == 0)
        {
            newArray[j] = sourceArray[i];
            j++;
        }
    }
    return newArray;
}

int length = 10;
int min = 10;
int max = 100;

int[] sourceArray = CreateSourceArray(length, min, max);
PrintArray(sourceArray);
int[] evenArray = GetEvenArray(sourceArray);
PrintArray(evenArray);