// Убрать из массива все элементы с длиной больше 3 символа.

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

string ReadString(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine()!;
}

string[] ReadStringArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < length; i++)
        array[i] = ReadString($"Enter element #{i + 1}: ");
    return array;
}

void PrintStrArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
}

int length = ReadInt("Enter array size: ");
