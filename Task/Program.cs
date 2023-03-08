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

void PrintStrArray (string[] array, string text)
{
    Console.WriteLine(text);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.WriteLine();
}

bool ElementIsBig (string element, int length)
{
    if (element.Length > length)
        return true;
    else return false;
}

int CountingSpecificLengthElements(string [] array, int length)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(!ElementIsBig(array[i], length)) count++;
    return count;
}

string[] RemoveBigElements(string [] array, int cutOffLength)
{
    string [] newArray = new string[CountingSpecificLengthElements(array, cutOffLength)];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (!ElementIsBig(array[i], cutOffLength))
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

int length = ReadInt("Enter array size: ");
string[] originalArray = ReadStringArray(length);
PrintStrArray(originalArray, "Created array: ");
int cutOff = ReadInt("Enter the cut-off length for elements of the array: ");
string[] modifiedArray = RemoveBigElements(originalArray, cutOff);
PrintStrArray(modifiedArray, $"Modified array without elements longer than {cutOff}: ");