using static System.Console;
Clear();

WriteLine("Enter a number");
int number = int.Parse(ReadLine()!);

if (number > 7) {   WriteLine("Вы вышли за пределы недели.");}
else 
if (number == 1){   WriteLine("Нет");}
if (number == 2){   WriteLine("Нет");}
if (number == 3){   WriteLine("Нет");}
if (number == 4){   WriteLine("Нет");}
if (number == 5){   WriteLine("Нет");}
if (number == 6){   WriteLine("Да");}
if (number == 7){   WriteLine("Да");}