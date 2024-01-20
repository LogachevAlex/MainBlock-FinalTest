// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int length) //Создание массива. В качестве аргумента передается длина массива, пользователь заполняет каждый элемент массива типа string
{   
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Пожалуйста, введите {i+1} элемент массива");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray (string[] array) //Печать массива
{   
    if (array.Length == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    
    Console.Write("[");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

int CountElementsUnder3Chars (string[] array) //Подсчет элементов в массиве длиной меньше 3
{   
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] DuplicateArray(string[] array, int length) //Создание второго массива. В качестве аргумента передается исходный массив, возвращается новый массив только с элементами длины меньше 3. 
{
    string[] newArray = new string[length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Давайте создадим массив, введите желаемую длину массива: ");
// int userLength = int.Parse(Console.ReadLine()!);
int userLength = 0;
while (!int.TryParse(Console.ReadLine(), out userLength) || userLength < 1)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число больше 0: ");
}

string[] userArray = CreateArray(userLength);
PrintArray(userArray);
int arrayCount = CountElementsUnder3Chars(userArray);
string[] duplicatedArray = DuplicateArray(userArray, arrayCount);
Console.Write(" -> ");
PrintArray(duplicatedArray);

