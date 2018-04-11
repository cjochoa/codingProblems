using System;
public class Test
{
    public static void Main()
    {
        Console.WriteLine("result was " + LongestConsecutiveChar("abbbbcdeeehhggssaa"));
    }
    
    private static Tuple<char, int> LongestConsecutiveChar(string input)
    {
        int maxCount = -1, curCount = 1;
        char maxChar = '\0', prevChar = '\0';
        foreach (char c in input)
        {
          if (prevChar == c) 
          {
            curCount++;
          }
          else 
          {
            if (curCount >= maxCount)
            {
              maxCount = curCount;
              maxChar = prevChar;
            }
            prevChar = c;
            curCount = 1;
          }
        }
        return Tuple.Create(maxChar, maxCount);
    }
    
    
}