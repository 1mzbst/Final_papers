// int size = 4;
// string[] arrString = new string[size];
// Random qwe = new Random();
// for (int i = 0; i < size; i++)
// {
//     arrString[i] = Convert.ToString(qwe.Next('q', 'q' + 27));
//     // if (arrString[i].Length <= 3)
//     // {
//     Console.Write(arrString[i] + ",");
//     // }
// }

// // randoms[r.Next(0, randoms.Length)];
// //  array[i] = new Random().Next(minValue, maxValue + 1);

string[] CreateStringArr(int size)
{
    string[] array = new string[size];
    Console.WriteLine($"Enter the {size} words:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

void threeLetter(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + ", ");
        }
    }
}

Console.WriteLine("Enter the size of the array.");
int size = Convert.ToInt32(Console.ReadLine());
string[] someArray = CreateStringArr(size);
ShowArray(someArray);
threeLetter(someArray);
