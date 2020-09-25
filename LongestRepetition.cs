using System;
using System.Linq;

public static class LongestRepetition
 {
    public static Tuple<char?, int> Run(string input)
      {
        if (string.IsNullOrEmpty(input))
          return new Tuple<char?, int>(null, 0);
        
        
        var array =  input.ToArray();

        char winnerChar = array[0];
        int winnerStreak = 1;
        
        char pastChar = array[0];
        int  pastStreak = 1;
        for (int i =1; i<array.Length; i++)
        {

            if (pastChar == array[i] )
            {
                pastStreak++;

                if (winnerStreak < pastStreak)
                {
                    winnerChar = pastChar;
                    winnerStreak = pastStreak;
                }

            }
            else
            {
                pastChar = array[i];
                pastStreak = 1;
            }
        }
        
          return new Tuple<char?, int>(winnerChar, winnerStreak);
      }

 }