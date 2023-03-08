// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] CreateArray(int size)
{
    if (size <= 0)
    {
        throw new ArgumentException("Array size must be positive.");
    }
    
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    Console.Write("['");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("', '");
        }
    }
    Console.WriteLine("']");
}

void CheckArray(string[] array)
{
    Console.Write("An array of values with more than 3 elements: ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"'{array[i]}' ");
        }
    }
    Console.Write("]");
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateArray(size);
Console.Write("The introduced array looks like: ");
ShowArray(myArray);
CheckArray(myArray);
