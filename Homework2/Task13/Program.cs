using static System.Console;
Clear();

int a = 12345;
WriteLine(a);

if (a>100 && a<999){    int a1 =a%10;   WriteLine(a1);}
else if (a>1000 && a<9999){ int a1=a/10;    int a2=a1%10;   WriteLine(a2);}
else if (a>10000 && a<99999){ int a1=a/100;    int a2=a1%10;   WriteLine(a2);}
else{   WriteLine("Третьей цифры нет");}