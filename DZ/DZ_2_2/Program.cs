//Удалить вторую цифру трёхзначного числа.

//int number = 12345;
//int position = 2;
//int m = 1;
//while (position > 1) {
//m *= 10;
//position--;
//}
//int number2 = (number % m) + (number / (m * 10)) * m;
//Console.WriteLine(number2);

//Удалить вторую цифру трёхзначного числа.

//Найти третью цифру числа или сообщить, что её нет

Random rand = new Random();
int a = rand.Next(1,8);
Console.WriteLine(Get_2(a));
string Get_2(int a)
{
Console.WriteLine(a);
if(a ==6) return $"{a} - Суббота";
else if(a ==7)
return $"{a} - Воскресенье";
else
return "Будни";
}