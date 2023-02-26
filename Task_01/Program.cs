// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] MyArray(int size)
{
    int [] myArray = new int[size];
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
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

int SumEvenNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum++;
    }
    return sum;
}

int sizeArray = IntputSizeArray("Введите размер массива ");
int [] myArray = MyArray(sizeArray);
PrintArray(myArray);

Console.WriteLine($"Колличество чётных чисел в массиве равно {SumEvenNumber(myArray)}");