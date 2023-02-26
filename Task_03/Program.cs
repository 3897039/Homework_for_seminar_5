// Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] MyArray(int size)
{
    int [] myArray = new int[size];
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next();
    }
    return myArray;
}

void PrintArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($" {myArray[i]} ");
    }
}

int IntputSizeArray(string msg)
{
    Console.WriteLine($" {msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeNumber(int[] array)
{
    int maxNumber = array[0];
    int minNumber = array[1];
    if(maxNumber < minNumber)
    {
        maxNumber = minNumber;
        minNumber = array[0];
    }
    for (int i = 2; i < array.Length; i++)
        {
            if (array[i] > maxNumber) maxNumber = array[i];
            if (array[i] < minNumber) minNumber = array[i];
        }
    return  Math.Round(maxNumber - minNumber,2); 
}

int sizeArray = IntputSizeArray("Введите размер массива ");
int [] myArray = MyArray(sizeArray);
PrintArray(myArray);


Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DegreeNumber(myArray)}");