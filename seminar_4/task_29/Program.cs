using static System.Console;
Console.WriteLine("Введите число");
int A = int.Parse(ReadLine());
int multi = 1;
for (int i = 1; i <= A; i++)
{   
    multi = i * multi;
}
if (A == 1)
    {
        WriteLine("i");
    }
Console.WriteLine(multi);