Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int n1 = (0);
if (n >=100 && n < 1000){
    n1 = (n / 10);
    Console.WriteLine(n1 % 10);}
else
    Console.WriteLine("no");





