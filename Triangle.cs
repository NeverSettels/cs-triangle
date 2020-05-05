using System;

public class Triangle
{


  public static void WhatTriangle(int SideA, int SideB, int SideC)
  {
    if (SideA + SideB < SideC || SideB + SideC < SideA || SideA + SideC < SideB)
    {
      Console.Write("You do not have a triangle.");
    }
    else if (SideA == SideB && SideA == SideC)
    {
      Console.Write("You have an equilateral triangle.");
    }
    else if ((SideA == SideB && SideC != SideA) || (SideB == SideC && SideA != SideB) || (SideA == SideC && SideB != SideA))
    {
      Console.Write("You have an isoceles triangle.");
    }
    else
    {
      Console.Write("You have a scalene triangle.");
    }
  }
  public static void Main()
  {
    Console.Write("Enter the first side: ");
    int SideA = int.Parse(Console.ReadLine());
    Console.Write("Enter the second side: ");
    int SideB = int.Parse(Console.ReadLine());
    Console.Write("Enter the third side: ");
    int SideC = int.Parse(Console.ReadLine());

    WhatTriangle(SideA, SideB, SideC);
  }
}