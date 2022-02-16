
//Даны два числа. Показать большее и меньшее число

/*int numberA = new Random().Next(20, 100);
int numberB = new Random().Next(20, 100);
int Max = numberA;
int Min = numberB;

if (numberA < numberB)
{
    Max = numberB;
    Min = numberA;


}
Console.WriteLine(" Максимальное число " + Max);
Console.WriteLine(" Минимальное число " + Min);

*/
//Найти максимальное из трёх чисел.

/*int numberA = 31;
int numberB = 5;
int numberC = 20;
int Max = numberA;

if (numberA > Max) Max = numberA;
if (numberB > Max) Max = numberB;
if (numberC > Max) Max = numberC;

Console.WriteLine("Максимальное число " + Max);
*/

// Выяснить является ли число чётным

/*int num = new Random().Next(1, 100);
if (num % 2 == 0)
{
    Console.WriteLine(num + " - Это четное число");
}
else
{
    Console.WriteLine(num + " - Это нечетное число ");

}
*/

//Показать чётные числа от 1 до N.

/*Console.WriteLine("Ввведите N ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
if (i % 2 == 0)
Console.WriteLine(i);
Console.WriteLine("Выше выведены все четные числа в веденном диапозоне");
*/


//Показать вторую цифру трёхзначного числа
/*int number = 725;

do
{
    number = number / 10;

    if (number < 100)
    {
        Console.WriteLine("Вторая цифра : {0}", number.ToString().ToCharArray()[1]);
    }
}
while (number > 100);
*/

//Показать вторую цифру трёхзначного числа

/*int number = 29128;

do
{
    number = number / 10;

    if (number < 100)
    {
        do
        {
            number = number - 10;

            if (number < 10)
            {
                Console.WriteLine("Вторая цифра : {0}", number);
            }
        }
        while (number > 10);
    }
}
while (number > 100);
*/

/*int number = 123;

var str = number.ToString();

number = int.Parse(str.Remove(str.Length - 3, 1));
Console.WriteLine(number);




int n = int.Parse(textBox1.Text);
   int n1 = Convert.ToInt32(Math.Sqrt(n));
  if(n1*n1 == n)
    MassegeBox.Show("Yes");
  else
   MassegeBox.Show("No");
 

//тернарный , задача 17
string answer= a==b*b?"a квадрат b":b==a*a?"b квадрат a":"а и b не квадраты друг друга";
        int max=a>b?a:b;


Random rand = new Random();
int a = rand.Next(1,8);
Console.WriteLine(Get_2(a));
string Get_2(int a)
{
Console.WriteLine(a);
if(a ==6) return $"{a} - день недели, Суббота";

else if(a ==7)

return $"{a} - день недели, Воскресенье";
else

return "Рабочие дни"
*/