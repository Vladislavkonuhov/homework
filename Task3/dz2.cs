// Для 5 строчки пришлось залесть в интернет, так как незнал как конвертировать int в string)
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
string n1 = Convert.ToString(n);
if (n1.Length > 2)
  Console.WriteLine(n1[2]);
else 
  Console.WriteLine("третьей цифры нет");

