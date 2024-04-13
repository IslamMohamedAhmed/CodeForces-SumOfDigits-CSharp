using static System.Console;
using static System.Convert;
using static System.Math;


string str;
int counter = 0;


str = ReadLine();


while(str.Length != 1)
{
    long sum = 0;
    for(int i=0;i<str.Length; i++)
    {
        sum += str[i] - '0';
    }
    str = $"{sum}";
    counter++;
}

WriteLine(counter);