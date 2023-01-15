/*Задача 27: Напишите программу, реализующую метод, 
который принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/
using static System.Console;
Clear();
WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
WriteLine($"{GetSum(number)}");


int GetSum (int A) // 4 type вид метода принимает и возвращает return
{
    int result = 0;
    while (A>0)
    {
        result = result+A%10;
        A/=10;       
    }
    
    return result;
}
