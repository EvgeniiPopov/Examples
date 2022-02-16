using static System.Console;

WriteLine ("Введите координаты x");
int x = Convert.ToInt32(ReadLine());

WriteLine ("Введите координаты y");
int y = Convert.ToInt32(ReadLine());


WriteLine(coordinateSystem (x,y));

string coordinateSystem ( int x,int y )
{
    if (x>0 & y>0) return $"Первая четвреть";
    if (x>0 & y<0) return $" Четвертая четверть ";
    if (x<0 & y< 0) return $"Третья четверть";
    if (x<0 & y>0) return $"Вторая четверть";
}