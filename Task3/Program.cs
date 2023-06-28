
using System;
using static System.Console;

WriteLine("Введите значение M");
long m = long.Parse(ReadLine());
WriteLine("Введите значение N");
long n = long.Parse(ReadLine());  

if (m < 0 || n < 0) {
    WriteLine("Введены некорректные значения M и N");;
}

long result = akkerman(m, n);
WriteLine(result);

long akkerman(long m, long n) {
    if (m == 0) {
        return n + 1;
    }
    if (n == 0) {
        return akkerman(m-1, 1);
    }
    return akkerman(m-1, akkerman(m, n-1));
}
