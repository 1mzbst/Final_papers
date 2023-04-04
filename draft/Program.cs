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

string[] CreateStringArr(int size) // Метод создание массива состоящего из строк.
{
    string[] array = new string[size];
    Console.WriteLine($"Enter the {size} words:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
        if (array[i] == "") // Условие, если пользователь пропустил ввод слова.
        {
            array[i] = "empty_index";
        }
    }
    return array;
}

void ShowArray(string[] array) // Метод вывода массива в консоль.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

void threeLetter(string[] array) // Метод вывода нового массива, состоящего из индексов удовлетворяющих условие задачи.
{
    Console.Write("This is the new array from three or less letters in a word: [");
    for (int i = 0; i < array.Length; i++)
    {
        // if (array[i].Length <= 3)
        // {
        //     Console.Write(array[i] + ", ");
        // }
        // else if (i == array.Length - 1)
        // {
        //     Console.Write("ho ho ho");
        // }
        if (array[i].Length <= 3) Console.Write(array[i]);
        if (i == (array.Length - 1)) Console.Write("]");
        //Console.Write(" ");

    }
    //Console.Write("]");
}

Console.WriteLine("Enter the size of the array.");
int size = Convert.ToInt32(Console.ReadLine());
string[] someArray = CreateStringArr(size);
Console.WriteLine($"It is the entered array from any {size} words.");
ShowArray(someArray);
threeLetter(someArray);
