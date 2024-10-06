public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        int[] arr = new int[words.Length];
List<int> list = new List<int>();
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Contains(x))
        list.Add(i);
    
}
return list;
    }
}