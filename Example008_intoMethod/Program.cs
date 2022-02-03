int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 3, b1 = 4, c1 = 6, a2 = 7, b2 = 8, c2 = 9, a3 = 2, b3 = 6, c3 = 10;

//int max1 = max(a1, b1, c1);
//int max2 = max(a2, b2, c2);
//int max3 = max(a3, b3, c3);
//int max = Max(max1, max2, max3);


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
