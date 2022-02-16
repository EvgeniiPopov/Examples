//25. Найти сумму чисел от 1 до А

using static System.Console;
Console.WriteLine("Введите число");
int A = int.Parse(ReadLine());
int sum = 1;
for (int i = 2; i <= A; i++)
{   
    sum = i + sum;
    WriteLine($"{sum - i} + {i} = {sum}");
    

}
if (A == 1)
    {
        WriteLine("i");
    }