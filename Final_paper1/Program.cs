﻿// Условие задачи:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. 

//Решение:

string[] CreateStringArr(int size) // Метод создание массива состоящего из строк.
{
    string[] array = new string[size];
    Console.WriteLine($"Enter the {size} words:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine(); // Ввод осуществляется через консоль, вручную.
        if (array[i] == "") // Условие, если пользователь пропустил ввод слова.
        {
            array[i] = "empty_index";
        }
    }
    return array;
}