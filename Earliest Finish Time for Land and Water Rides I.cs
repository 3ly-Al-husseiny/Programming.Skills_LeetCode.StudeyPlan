public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        
		int landFinishTime = 0; 
		int waterFinishTime = int.MaxValue; 
		for(int i = 0; i < landStartTime.Length; i++)
		{
			if(i == 0)
			landFinishTime = landStartTime[i] + landDuration[i];
			else if (landFinishTime < landStartTime[i] + landDuration[i])
				landFinishTime = landStartTime[i] + landDuration[i];
		}
		
		for(int j = 0; j < landDuration.Length; j++)
		{
			if(waterStartTime > landFinishTime)
				continue;
			else if(waterFinishTime > waterStartTime[j] + waterDuration[j])
				waterFinishTime = waterStartTime[j] + waterDuration[j];
		}
		
		return waterFinishTime;
		
    }
}