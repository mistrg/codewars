public class DotsAndBoxesValidator
{
    public static int[] DotsAndBoxes(int[][] r)
    {
        // check the dimensions of the array
        var size = r.Length / 4;


        for (int i = 0; i < r.Length; i++)
        {
            //Move

            //check if square closed
            IsClosingBox(r, r[i]);
        }
        return null;
    }

    private static bool IsClosingBox(int[][] r, int[] move)
    {
        
        return false;
    }
}