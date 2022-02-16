Console.WriteLine("Введите значение числа n: ");
string text = Console.ReadLine();
int y = text[text.Length - 1] - '0';
int n = y * y;
Console.WriteLine("n = {0,3}", n);
 
Console.WriteLine("Последняя числа нашего прекрасного числа {0,5}", y);