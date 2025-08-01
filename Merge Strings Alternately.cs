// ---------------------------------- Your Wrong Solve 

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int firstStringIndex = 0; 
		int secondStringIndex = 0; 
		StringBuilder Result = new StringBuilder();
		
		for(int i =0; i < (word1.Length + word2.Length); i++)
		{
			if(firstStringIndex < word1.Length)
				if((firstStringIndex == secondStringIndex) || (firstStringIndex >= secondStringIndex && secondStringIndex >= word2.Length) )
                {
				Result.Append(word1[firstStringIndex].ToString());
                firstStringIndex++;
                }
				
			else if(secondStringIndex < word2.Length)
            {
				Result.Append(word2[secondStringIndex].ToString());
                secondStringIndex++;
            }
		}
		return Result.ToString();
    }
}

// Another Simple and Correct Solution

public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int firstStringIndex = 0; 
		int secondStringIndex = 0; 
		StringBuilder Result = new StringBuilder();
		
		for (int i = 0; i < (word1.Length + word2.Length); i++)
{
    if (i % 2 == 0 && firstStringIndex < word1.Length || !(secondStringIndex < word2.Length) )
    {
        Result.Append(word1[firstStringIndex++]);
    }
    else if (secondStringIndex < word2.Length)
    {
        Result.Append(word2[secondStringIndex++]);
    }
}

		return Result.ToString();
    }
}


// ---------------------------------- Another Solution 


public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0, j = 0;
        StringBuilder result = new StringBuilder();

        while (i < word1.Length || j < word2.Length) {
            if (i < word1.Length) result.Append(word1[i++]);
            if (j < word2.Length) result.Append(word2[j++]);
        }

        return result.ToString();
    }
}

