using System;
public class Test
{
    public static void Main()
    {
        Console.WriteLine("result 1 was " + FindSum(new int[]{1, 2, 4, 4}, 8));
        Console.WriteLine("result 2 was " + FindSum(new int[]{1, 2, 4, 9}, 8));
    }
    
    // Finds if there are two values on inputList that add up to sum
    // assumes inputList is sorted.
    private static bool FindSum(int[] inputList, int sum)
    {
        int i = 0;
        int j = inputList.Length - 1;
        
        for (; i < j;)
        {
            var actualSum = inputList[i] + inputList[j];
            if (actualSum == sum)
            {
                return true;    
            } 
            else if (actualSum > sum)
            {
                j--;
            }
            else 
            {
                i++;
            }
        }
        return false;
    }
}