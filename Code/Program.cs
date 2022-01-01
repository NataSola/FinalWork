// Создание массива

int length = 25;
int min = -50;
int max = 50;

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray (int[]array)
{
 for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"array[i]  ");
    }
}

