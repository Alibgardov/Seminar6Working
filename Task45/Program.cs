// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


//Этот код генерирует массив случайных чисел заданного размера и диапазона значений, копирует его в новый массив и выводит оба массива на консоль. 

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue) //Функция `GetArray` создает массив заданного размера и заполняет его случайными числами в диапазоне от `minValue` до `maxValue`. 

{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] arr) //Функция `CopyArray` создает новый массив той же длины, что и переданный массив `arr`, и копирует все его элементы в этот новый массив. 

{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

void PrintArray(int[] arr) //Функция `PrintArray` выводит все элементы массива `arr` на консоль, разделенные пробелами. 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(10, 0, 10); //В основной программе сначала создается массив, затем он выводится на консоль с помощью функции `PrintArray`.
// Затем создается копия этого массива с помощью функции `CopyArray`, и она также выводится на консоль.
PrintArray(array);
Console.WriteLine();
int[] copy = CopyArray(array);
PrintArray(copy);
Console.WriteLine();