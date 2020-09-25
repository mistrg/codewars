using System.Collections.Generic;
using System.Linq;
public static class MadRobotProblem
{

    public static char[] BoxVisibleDirections(string loadingHistory, int madRobotIndex)
    {
        //populate 3d model
        
        var allPos = loadingHistory.Split(" ");

        if (allPos.Length<=madRobotIndex)
            return new char[] {};

        var missPos = allPos[madRobotIndex];
        var missPosX  = int.Parse(missPos.Split(";")[0]);
        var missPosY  = int.Parse(missPos.Split(";")[1]);
        var missHeight = 0;

        int[] nord = new int[100];
        int[] south = new int[100];
        int[] east = new int[100];
        int[] west = new int[100];

        for(int i = 0; i<allPos.Length; i++)
        {
            var pos = allPos[i];
            var x = int.Parse(pos.Split(";")[0]);
            var y = int.Parse(pos.Split(";")[1]);
            
            if (x == missPosX)
            {
                if (y < missPosY)
                    nord[y]++;
                if (y > missPosY)
                    south[y]++;
            }

            if (y == missPosY)
            {
                if (x < missPosX)
                    west[x]++;
                if (x > missPosX)
                    east[x]++;
            }
            if (x == missPosX && y == missPosY && i<= madRobotIndex)
                missHeight++;

        }

        var result = new List<char>();
        
        if (nord.All(p=>p<missHeight))      
            result.Add('n');
        if (west.All(p=>p<missHeight))
            result.Add('w');
        if (south.All(p=>p<missHeight))
            result.Add('s');
        if (east.All(p=>p<missHeight))
            result.Add('e');

        return result.ToArray();

    }
}