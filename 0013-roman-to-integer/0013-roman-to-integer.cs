public class Solution {
    public int RomanToInt(string s)
        {
            Dictionary<char, int> Roman = new Dictionary<char, int>
 {
     {'I',1 },{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
 };
 int sum = 0;
 int PreValue = Roman[s[0]];
 for(int i = 1; i < s.Length; i++)
 {
     int CurrentValue = Roman[s[i]];
     sum += (CurrentValue > PreValue) ? -PreValue : PreValue;
     PreValue =CurrentValue;
 }
 sum += PreValue;
 return sum;
        }


}