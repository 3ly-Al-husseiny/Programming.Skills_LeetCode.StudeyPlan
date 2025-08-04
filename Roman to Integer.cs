public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        Dictionary<char, int> romanValues = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        for (int i = 0; i < s.Length; i++) {
            int currentVal = romanValues[s[i]];
            if (i < s.Length - 1) {
                int nextVal = romanValues[s[i + 1]];
                if (currentVal < nextVal) {
                    sum += nextVal - currentVal;
                    i++; // Skip the next character
                    continue;
                }
            }
            sum += currentVal;
        }
        return sum;
    }
}