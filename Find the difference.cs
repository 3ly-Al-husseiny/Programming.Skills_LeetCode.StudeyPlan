public class Solution {
    public char FindTheDifference(string s, string t) {
        // s --> is the Original StringBuilder
		// t --> is the s string with a random char with shuffeld
		
		int sSum = 0; 
		int tSum = 0; 
		
		for(int i = 0; i < t.Length; i ++)
		{
			if(i == t.Length - 1)
				sSum += 0;
			else
			sSum += (int)s[i];
			
			tSum += (int)t[i];
		}
		
		return (char)(tSum - sSum);
		
    }
}