public class Function
{
    public static bool IsGoodBinaryString(string binaryString)
    {
        if (string.IsNullOrEmpty(binaryString)) return false;

        int count0 = 0;
        int count1 = 0;

        foreach (char c in binaryString)
        {
            if (c == '0')
            {
                count0++;
            }
            else if (c == '1')
            {
                count1++;
            }
            else
            {
                return false;
            }

            if (count1 < count0)
            {
                return false;
            }
        }

        return count0 == count1;
    }
}
