public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums)
        {        
int[] result=new int[nums.Length];
 int Counter=0;           
 for (int i = 0; i < nums.Length; i++)
 {
    for(int j = 0; j < nums.Length; j++)
     {
         if (nums[i] > nums[j])
         {
             Counter++;
         }
         result[i] = Counter;          
     }
     Counter = 0;
 }
 return result;
        }
        
}