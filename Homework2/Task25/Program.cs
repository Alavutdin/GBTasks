/*Задача 25: Напишите программу, реализующую метод,который 
принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B с использованием цикла.
В задаче не использвать стандартный метод Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
using static System.Console;
Clear();

WriteLine("Введите число: ");
int number1 = int.Parse(ReadLine()!);
int number2 = int.Parse(ReadLine()!);

int sum = GetSum(number1, number2);
WriteLine($"{sum}"); // можно WriteLine($"{GetSum(number1, number2)}");

int GetSum(int A, int B) // 4 type вид метода
{
    int result=1;
    for (int i = 1; i <= B; i++)
    {
        result*=A; 
    } 
    return result;   // вернуть 
}
