public class Solution {
    public void MoveZeroes(int[] nums) {
        for(int i = 0; i < sum.Length; i++)
		{
			if(nums[i] == 0)
				for(int j = 0; j < sum.Length - 1; j++)
				{
					if(nums[j] == 0 && num[j+1] != 0)
						(nums[j] , num[j+1]) = (nums[j+1] , num[j])
				}
		}
		return num;
    }
}