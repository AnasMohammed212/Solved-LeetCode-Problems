public class Solution {
    public void ReverseString(char[] s) {
      int Left = 0,Right=s.Length-1;
     while (Left < Right)
     {
    char Temp = s[Left];
    s[Left] = s[Right];
    s[Right] = Temp;
    Left++;
    Right--;
     }
    }
}