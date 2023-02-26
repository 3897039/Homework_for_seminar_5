// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] MyArray(int length,int minValue, int maxValue)
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
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int DiffNumber(int[] array)
{
    int maxNumber = 0;
    int minNumber = 0;
    int diffnumber = 0;
        for(int i = 0; i < array.Length; i++)
        {
            {
                {
                    if(maxNumber < array[i]) maxNumber = array[i];
                }
                return maxNumber;
                 {
                    if(minNumber < array[i]) minNumber = array[i];
                 }
                return minNumber;
            }
            diffnumber = maxNumber - minNumber;
        } 
        return diffnumber;     
}

int size = 10;
int minValue = 1;
int maxValue = 200;
int[] myArray = MyArray(size, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DiffNumber(myArray)}");




