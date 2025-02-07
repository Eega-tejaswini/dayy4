// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using MultiCastDe;

MathOpDel mth = new MathOpDel(MathOper.Add);

mth.Invoke(10, 20); 
mth(30, 20);

mth += MathOper.Sub;
mth += MathOper.Mul; 
mth += MathOper.Div;
mth(50, 50);

mth -= MathOper.Div;
mth(50, 60);


// function Delegates
Func<int, int, int, int> fundel = delegate (int x, int y, int z)
{
    return x + y + z;
};
Console.WriteLine(fundel(10, 20, 30));


Func<int, int> fundellam = x => x * x;
Console.WriteLine(fundellam(20));

// action delegates

Action<int, int> actiondel = (x, y) => Console.WriteLine(x + y);

actiondel(10, 20);

//Predicate delegates


Predicate<int> isEven = (num) => num % 2 == 0;

if (isEven(10)) 
{
    Console.WriteLine("Num value is even");
}
else
{
    Console.WriteLine("Num values is odd");
}
