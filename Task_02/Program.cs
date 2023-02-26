// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

int [] MyArray(int size)
{
    int [] myArray = new int[size];
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(-100, 101);
    }
    return myArray;
}

void PrintArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($" {myArray[i]},  ");
    }
}

int IntputSizeArray(string msg)
{
    Console.WriteLine($" {msg} ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOddIndex (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if( i % 2 != 0) sum += array[i];
    }
    return sum;
}

int sizeArray = IntputSizeArray("Введите размер массива ");
int [] myArray = MyArray(sizeArray);
PrintArray(myArray);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOddIndex(myArray)}");