public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0; 
        for(int i = s.Length-1; i >= 0; i--)
        {
            if(s[i] != ' ')
            {
                for(int j = i; j >= 0; j--)
                {
                if(s[j] != ' ')
                len++;  
                 else    
                return len;
                }
                return len;
            }
        }
         return len;
    }
}