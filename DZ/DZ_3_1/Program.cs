//4. Найти кубы чисел от 1 до N|

/*using System;


System.Console.WriteLine("Введите число N: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= b; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));

}


//22. Найти расстояние между точками в пространстве 2D/3D

using System;

{
    double x1 = 0, y1 = 0, z1 = 0, x2 = 0, y2 = 0, z2 = 0;

    Console.Write("Введите координату x1: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y1: ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z1: ");
    z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату x2: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y2: ");
    y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату z2: ");
    z2 = Convert.ToDouble(Console.ReadLine());

    {
        double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine("Расстояние между точками равно: " + rasst);
    }
}



//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

var random = new Random();
bool x = random.Next(2) == 1;
bool y = random.Next(2) == 1;
bool result;
if (!(x | y) == !x & !y)
{
    result = true;
}

else
{
   result = false; 
}

Console.WriteLine(result);*/


//20. Задать номер четверти, показать диапазоны для возможных координат


/*Console.WriteLine("Введите координату х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

    if ((x > 0) & (y > 0))
    Console.WriteLine("координаты находятся в 1 четверти");
    if ((x < 0) & (y > 0))
    Console.WriteLine("Координаты находятся во 2 четверти");
    if ((x < 0) & (y < 0))
    Console.WriteLine("Координаты находятся в 3 четверти");
    if ((x > 0) & (y < 0))
    Console.WriteLine("Координаты находятся в 4 четверти");


// 20. Задать номер четверти, показать диапазоны для возможных координат

System.Console.WriteLine("Введите интересущущий номер четверти от 1 до 4");
int quater = Convert.ToInt32(Console.ReadLine());

if (quater == 1)
    {
        Console.WriteLine("Диапазон координт (x > 0) ; (y > 0)");
    }
if (quater == 2)
    {
        Console.WriteLine("Диапазон координт (x < 0) ; (y > 0)");
    }
if (quater == 3)

    {
        Console.WriteLine("Диапазон координт (x < 0) ; (y < 0)");
    }
if (quater == 4)
{
    Console.WriteLine("Диапазон координт (x > 0) ; (y < 0)");
}
else
{
    System.Console.WriteLine("Введен некорректный номер четверти");
}

// 26. Возведите число А в натуральную степень B используя цикл

using System;

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите cтепень числа");
int pow = int.Parse(Console.ReadLine());

for(int power = 0; power <= pow; power++)


    Console.WriteLine($"{num}^{power} = {Math.Pow(num, power)}");


//28. Подсчитать сумму цифр в числе

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int summ = 0;
while (num > 0)
{
    summ = summ + num % 10;
    num /= 10;

}

System.Console.WriteLine(summ);


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Вычитание_элемента
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int count5 = 0;
            int []arr=new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,100);
                Console.Write(arr[i]+" ");
 
            }
            Console.WriteLine();
 
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0)
                {
                    counter++;
                }
 
                if (arr[i] % 5 == 0 && arr[i] % 10 != 0)
                {
                    count5++;
 
                }
            }
 
 
            Console.WriteLine("Четных чисел: " + counter );
            Console.WriteLine("Чисел заканчивающихся на 5: "  + count5);
            Console.ReadKey();
        }
    }
}



//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
short[] nums = new short[8];

for (byte i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt16 (new Random().Next(0, 2));

Console.WriteLine(nums[i]);
}



using static System.Console;

WriteLine("Введите пятизначное число 6-ти значное число");
string a = ReadLine();


WriteLine(happyTickets(a));


string happyTickets(string number)
{
    string answer=(number[0] + number[1] + number [2] == number[3] + number[4] + number[5])?"счастливый билет":"Увы,попробуй еще раз";
    return answer;
    

}
*/
// 30. Показать кубы чисел, заканчивающихся на четную цифру

short[] nums = new short[8];

for (byte i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt16(new Random().Next(0, 20));
    if (nums[i] % 2 == 0)
    continue;
Console.WriteLine($"{nums[i]}^{3} = {Math.Pow(nums[i], 3)}");
}
