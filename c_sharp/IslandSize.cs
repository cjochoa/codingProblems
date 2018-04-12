//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        private const int N = 3;
        private const int M = 4;
        
        public static void Main(string[] args)
        {
            int[,] matrix = new int[N,M] {
                {0,0,1,0},
                {0,1,1,0},
                {1,0,1,0}};
                 
            Console.WriteLine("Island size is " + IslandSize(matrix, 2, 0));
        }
        
        private static int IslandSize(int[,] matrix, int i, int j) 
        {
            int[,] marks = new int[N,M] {
                {0,0,0,0},
                {0,0,0,0},
                {0,0,0,0}};
            return IslandSizeTemp(matrix, marks, i, j);
        }
        
        
        private static int IslandSizeTemp(int[,] matrix, int[,] marks, int i, int j) 
        {
            if (i<0 || j<0 || i>=N || j>=M) 
            {
                return 0;
            }
            if (matrix[i,j] == 0)
            {
                return 0;
            }
            if (marks[i,j] == 1)
            {
                return 0;
            } 
            
            marks[i,j] = 1;
            return 1 + IslandSizeTemp(matrix, marks, i-1,j) + 
                       IslandSizeTemp(matrix, marks, i+1,j) +
                       IslandSizeTemp(matrix, marks, i,j-1) +
                       IslandSizeTemp(matrix, marks, i,j+1); 
        }
    }
}