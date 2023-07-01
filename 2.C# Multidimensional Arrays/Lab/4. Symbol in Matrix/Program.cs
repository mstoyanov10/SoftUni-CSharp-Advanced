﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];



for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] rowData = Console.ReadLine().ToCharArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];

    }

}
string symbol = Console.ReadLine();
bool found = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row,col].ToString() == symbol)
        {
            found = true;
            Console.WriteLine($"({row}, {col})");
            break;
        }


    }
    if (found)
    {
        break;
    }

}
if (!found)
{

    Console.WriteLine($"{symbol} does not occur in the matrix");

}