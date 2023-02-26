// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] MyArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] DegreeNumber(int[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    degreeNumber = maxNumber - minNumber;
    {
        for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < minNumber) minNumber = array[i];
    }
    return degreeNumber;
    }
}

int size = 10;
int minValue = 1;
int maxValue = 50;
int[] myArray = MyArray(size, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DegreeNumber(myArray)}");