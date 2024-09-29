public class Solution {
    public string ReplaceDigits(string s) {
        
string result = "";
            for(int i = 0; i < s.Length;i++)
            {
                if(s[i] >= '0' && s[i] <= '9')
                {
                    result += (char)(s[i - 1] + (s[i] - '0'));
                }
                else
                {
                    result += s[i];
                }
            }
            return result;
    }
}