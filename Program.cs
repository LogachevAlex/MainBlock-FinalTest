// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int length)
{   
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Пожалуйста, введите {i+1} элемент массива");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray (string[] array)
{   
    Console.Write("Ваш массив: [ ");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

Console.WriteLine("Давайте создадим массив, введите желаемую длину массива: ");
int userLength = int.Parse(Console.ReadLine()!);
string[] userArray = CreateArray(userLength);
PrintArray(userArray);