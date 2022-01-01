// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 

int[] CreateArray(int length, int min, int max)     // Создание исходного массива
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)    // Печать массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

int GetNumberEvenNumbers(int[] array)   // Подсчет количества четных элементов исходного массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] CreateEvenNumbersArray(int count, int[] sourceArray)  // Создание нового массива из четных элементов исходного массива
{
    int[] arrayEven = new int[count];
    int j = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i] % 2 == 0)
        {
            arrayEven[j] = sourceArray[i];
            j++;
        }
    }
    return arrayEven;
}

int length = 25;
int min = -50;
int max = 50;

int[] sourceArray = CreateArray(length, min, max);
PrintArray(sourceArray);
int count = GetNumberEvenNumbers(sourceArray);
int[] evenArray = CreateEvenNumbersArray(count, sourceArray);
PrintArray(evenArray);
