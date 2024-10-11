public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
         HashSet<char> allowedSet = new HashSet<char>(allowed);
        int consistentCount = 0; 
        foreach (string word in words)
        {
            bool isConsistent = true;

            foreach (char c in word)
            {
                if (!allowedSet.Contains(c))
                {
                    isConsistent = false;
                    break;
                }
            }
            if (isConsistent)
            {
                consistentCount++;
            }
        }

        return consistentCount;
    }
}