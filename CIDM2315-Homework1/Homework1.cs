namespace CIDM2315_Homework1 { 
using System;
/* Christopher Stephens
CIDM 2315
*/
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
        // Creating a string for X and Y values by concatenation
        string outputXY = "X = " + X + ", Y = " + Y;
        // Creating a string for Z value by interpolation
        string outputZ = ($"The value of Z is {Z}.");
        // Displaying line 1 and line 2 to console
        Console.WriteLine($"{outputXY}\n{outputZ}");
    }
}
}