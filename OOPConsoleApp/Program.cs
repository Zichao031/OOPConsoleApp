// See https://aka.ms/new-console-template for more information

using OOPConsoleApp.ColorAndBall;
using OOPConsoleApp.DataModel;
using OOPConsoleApp.WorkWithMethods;

// 1. reverse array
// ReverseArray.Main();

// 2. Fibonacci
// Fibonacci.Get(10);

// Color c = new Color(1,2,34);
// Console.WriteLine(c.GetAlpha());
// c.SetGreen(2);
// Console.WriteLine(c.GetAlpha());
// Console.WriteLine(c.GetBlue());
// c.SetBlue(22);
// Console.WriteLine(c.GetBlue());

Ball b = new Ball(10, new Color(1,2,3));
Console.WriteLine(b.ThrowTimes());
b.Throw();
Console.WriteLine(b.ThrowTimes());
b.Throw();

Console.WriteLine(b.ThrowTimes());
b.Pop();

Console.WriteLine(b.ThrowTimes());