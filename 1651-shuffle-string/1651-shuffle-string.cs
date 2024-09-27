public class Solution {
    public string RestoreString(string s, int[] indices) {
         string result = "";
 char[] Arr = new char[indices.Length];
 int i = 0;
 foreach (char c in s) {
     Arr[indices[i]] = c;
     i++;
 }
 for (int j=Arr.Length-1 ; j>=0; j--) {
     result = Arr[j]+result;
     
 }
 return result;
    }
}