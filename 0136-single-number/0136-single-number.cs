public class Solution {
    public int SingleNumber(int[] nums)
        {
           List<int> list = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(!list.Contains(nums[i]))
                    list.Add(nums[i]);
                else
                list.Remove(nums[i]);
            }
            return list.First();
            
        }
}