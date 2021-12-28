// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 

Random rnd = new Random();
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
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
int[] EvenNumbers(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array2[j] = array[i];
            j++;
        }
    }
    if (j == 0) Console.WriteLine("Чётных чисел в данном массиве нет!");
    return array2;
}

void PrintEvenArray(int[] array)
{
    for (int i = 0; i < j; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] RndArray = new int[10];

FillArray(RndArray);
System.Console.WriteLine("Целочисленный массив случайных чисел: ");
PrintRndArray(RndArray);
System.Console.WriteLine();
System.Console.WriteLine("Массив из отобранных чётных чисел: ");
PrintEvenArray(EvenNumbers(RndArray));
