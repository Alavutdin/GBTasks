using static System.Console;
Clear();

int number1 = new Random().Next(100,999);
WriteLine(number1);
int number2 = number1/10;
number2 = number1%10;
WriteLine(number2);