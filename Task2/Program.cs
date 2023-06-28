
using System;
using static System.Console;

WriteLine("Введите значение M");
int m = int.Parse(ReadLine());
WriteLine("Введите значение N");
int n = int.Parse(ReadLine());

if (m >= n) {
    WriteLine("Введены некорректное значение M и N");;
}

int result = sum(m, n);
WriteLine(result);

int sum(int m, int n) {
    if (m == n) {
        return n;
    }
    return m + sum(m+1, n);
}
