// ---------------- Trying Another Solution 

public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for (int len = 1; len <= s.Length / 2; len++) {
            if (s.Length % len == 0) {
                string pattern = s.Substring(0, len);
                bool isMatch = true;
                for (int i = len; i < s.Length; i += len) {
                    if (s.Substring(i, len) != pattern) {
                        isMatch = false;
                        break;
                    }
                }
                if (isMatch) return true;
            }
        }
        return false;
    }
}

//----------------------- My Solution with Logic Bug 

// public class Solution {
//     public bool RepeatedSubstringPattern(string s) {
//         StringBuilder repeated = new StringBuilder();
//         for (int i = 0; i < s.Length; i++)
//         {
//             if ((s[0] == s[i]) && i != 0)
//                for()
//             repeated.Append(s[i].ToString());
//         }
        
//         string stringRepeated = repeated.ToString();
        
//         // Add this check to avoid crashes!
//         if (s.Length % stringRepeated.Length != 0 || s.Length == 1)
//             return false;
        
//         for (int i = 0; i < s.Length; i += stringRepeated.Length)
//         {
//             if (stringRepeated != s.Substring(i, stringRepeated.Length))
//             {
//                 return false;
//             }
//         }
        
//         return true;
//     }
// }

// Note that You should get the solution then think how to optimize the code :(