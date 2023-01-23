namespace CIDM2315_Homework1 { 
using System;

class MathProgram
{
    static void Main(string[] args)
    {
        // defines float X as 2.5
        double X = 2.5; 
        // defines float Y as 3.3
        double Y = 3.3;
        // defines float Z as 4 times X^2 added to 3 times Y
        double Z = 4*X*X + 3*Y;
        Console.WriteLine(Z);
    }
}
}