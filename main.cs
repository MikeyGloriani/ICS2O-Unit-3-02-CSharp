// Created by: Mikey Gloriani
// Created on: Oct 2022
//
// This program displays the volume of a pyramid


using System;

class Program 
{
    public static void Main (string[] args) 
    {
        // This function accepts user input
        int length;
        int width;
        int height;
        int area;

        Console.WriteLine("This program displays the volume of a pyramid.");
        Console.WriteLine("");

        Console.Write("Enter the length (cm): ");
        length = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the width (cm): ");
        width = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        area = ((length*width*height)/3);

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + area + " cm³. ");

        Console.WriteLine("\nDone.");
    }
}