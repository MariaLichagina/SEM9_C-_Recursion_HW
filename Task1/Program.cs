using System;
using static System.Console;

WriteLine("Введите значение N");
int n = int.Parse(ReadLine());

if (n<=0) {
    WriteLine("Введено некорректное значение N");
}

printNaturalNumber(n);

void printNaturalNumber(int n) {
    Write(n);
    n = n-1;
    if (n > 0) {
        Write(", ");
        printNaturalNumber(n);
    }
}
