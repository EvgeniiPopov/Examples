//Программа проверяет пятизначное число на палиндромом.

int len = Array.length();
for(int i = 0; i < len/2; ++i)
	{
		if(Array[i] != Array[len-i-1])
		{
			return false;
		}
	}