// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, длина которых 
// меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int LongNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 0 && arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] SortingArray (string[] arr, int size)
{
    string [] newArr = new string [size];
    int j=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 0 && arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите количество строк, которые хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStr = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    arrayStr[i] = Console.ReadLine();
}

PrintArray(arrayStr);
int longNewArray = LongNewArray(arrayStr);
string[] sortingArray = SortingArray(arrayStr, longNewArray);
PrintArray(sortingArray);
