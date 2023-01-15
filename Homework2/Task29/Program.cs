/*Задача 29: Напишите программу, реализующую метод, 
который формирует массив случайных целых чисел 
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]*/
using static System.Console;
Clear();
int [] array = GetArray(); // Метод ничего не принимает, но возвращает массив
PrintArray(array); // Метод принимает массив но ни чего не возвращает.



int [] GetArray() // 3 вид метода из лекции
{
    int [] result = new int [8]; // массив 8 элементов
    for (int i = 0; i < result.Length; i++) 
    {
        Random rnd = new Random();
        result[i]=rnd.Next(0,34); // случайные числа от 0 до 33
    }

    return result;  // вернуть
}

void PrintArray(int [] arr) // 2 вид метода из лекции
{
    //int count = arr.Length;
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
        
    }
}