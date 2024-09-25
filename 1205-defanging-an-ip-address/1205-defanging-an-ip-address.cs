public class Solution {
    public string DefangIPaddr(string address) {
        var nums = address.Split('.');
var result = "";
for (int i = 0; i < nums.Length; i++) { 
    result += nums[i];
    if(i!=nums.Length-1)
        result +="[.]";

}
return result;
    }
}