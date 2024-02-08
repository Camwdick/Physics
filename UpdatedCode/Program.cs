using System;

namespace Euler
{
class Euler
{
public static void Main()
{
EulerMethod();
}

public static void EulerMethod()
{
//this program is designed to simulate free fall in the python programming language
//as you can see python is a really light in syntax programming language allowing us
//to model simulations like this in a really small amount of lines of code

//here we initialize a variable to the input of our use while prompting the user with a string of text
Console.WriteLine("Please enter total time object falls");
double timeInterval = double.Parse(Console.ReadLine());

//Same thing here
Console.WriteLine("Please enter the number of intervals");
int N = int.Parse(Console.ReadLine());

//in this line we initialize a new variable to an equation (timeInterval divided by N)
double dt = timeInterval / N;

//Initialize variables that will be needed for the calculations
double t = 0.0d;
double y = 0.0d;
double v1 = 0.0d;
double v0 = 0.0d;
double a = 9.8f;
double g = 9.8f;
double b = 0.035d;
double m = 4;

//\t in ascii means tab
Console.WriteLine("|i\t|t\t|a\t|v\t|y\t|");

//
for (int i = 0; i <= N; i++)
{
//Use Math.Round() to round variables to 2 decials
Console.WriteLine($"|{i}\t|{Math.Round(t, 2)}\t|{Math.Round(a, 2)}\t|{Math.Round(v1, 2)}\t|{Math.Round(y, 2)}\t|");
t += dt;
v0 = v1;
v1 += (a * dt);
y += (((v1+v0)/2) * dt);
a = g - ((b/m)*(v0*v0));
}
}
}
}