using System.Numerics;

public class Solution {
    public int[] PlusOne(int[] digits) {
        BigInteger Number = 0;
        for (int i = 0; i < digits.Length; i++) {
            Number *= 10;

            if (i != digits.Length - 1)
                Number += digits[i];
            else
                Number += digits[i] + 1;
        }

        string num = Number.ToString();
        int[] output = new int[num.Length];

        for (int i = 0; i < num.Length; i++) {
            output[i] = (int)(num[i] - '0');
        }

        return output;
    }
}
