using System;
using System.Threading;

Console.WriteLine("Hello, Jerry");

// Функция выполняется 3 раза
PrintABC();
Thread.Sleep(500);

PrintABC();
Thread.Sleep(500);

PrintABC();

// Вызываем функцию A три раза
A();
A();
A();

Console.ReadKey();

// Печатает A, B, C
void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

// Функция A вызывает B и C
void A()
{
    Console.WriteLine("Function A");
    B();
    C();
}

void B()
{
    Console.WriteLine("Function B");
}

void C()
{
    Console.WriteLine("Function C");
}