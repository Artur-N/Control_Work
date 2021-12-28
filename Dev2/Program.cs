// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.

Random rnd = new Random();
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-5, 12);
    }
}

void PrintRndArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int j = 0;
int[] MoreEight(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 8)
        {
            array2[j] = array[i];
            j++;
        }
    }
    if (j == 0) Console.WriteLine("Чисел больших 8 нет!");
    return array2;
}

void PrintArray2(int[] array)
{
    for (int i = 0; i < j; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] RndArray = new int[10];

FillArray(RndArray);
PrintRndArray(RndArray);
System.Console.WriteLine();
PrintArray2(MoreEight(RndArray));

