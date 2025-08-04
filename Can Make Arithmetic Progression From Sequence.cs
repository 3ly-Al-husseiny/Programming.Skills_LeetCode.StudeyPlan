public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int dif = Math.Abs(arr[0] - arr[1]);
        for(int i = 0; i < arr.Length - 1 ; i++)
        {
            if(Math.Abs(arr[i] - arr[i+1]) != dif)
                return false;
        }
        return true;
    }
}