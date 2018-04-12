using System;
public class Test
{
    public static void Main()
    {
        Console.WriteLine("result 1 was " + CountNegs(new int[,]{{-3, -2, -1, 1}, {-2, -1, 3, 4}, {-1, 5, 7, 8}}));
    }
    
    // Counts the number of negative numbers in a mxn matrix
    // assumes the matrix is sorted row-wise and column-wise
    private static int CountNegs(int[,] input)
    {
        int result = 0;

        for (int i = 0; i < input.GetLength(0); i++)
        {
          int j = input.GetLength(1) - 1;
          for (; j >= 0; j--)
          {
             if (input[i,j] < 0 ) 
             {
               result += j+1;
               break;
             }
          }
            
        }
        return result;
    }
    
    
}