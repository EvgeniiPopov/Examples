//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

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
    
    return "Рабочие дни";
    
}