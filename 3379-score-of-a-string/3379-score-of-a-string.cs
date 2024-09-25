public class Solution {
    public int ScoreOfString(string s) {
        int Sub=0,Sum = 0;
         for (int i = 1; i < s.Length; i++)
          {
          Sub = (int)s[i-1] - (int)s[i]; 
         Sum += Math.Abs(Sub);
          }
        return Sum;
    }
}