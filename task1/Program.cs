//
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter element {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
Console.Write("The introduced array looks like: ");
ShowArray(myArray);

