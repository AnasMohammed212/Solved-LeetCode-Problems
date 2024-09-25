public class Solution {
    public string ConvertDateToBinary(string date)
        {
            var dateArr=date.Split('-');
            int [] BinaryArr =new int[dateArr.Length];          
            BinaryArr[0]=Convert.ToInt32(dateArr[0]);
            BinaryArr[1] = Convert.ToInt32(dateArr[1]);
            BinaryArr[2] = Convert.ToInt32(dateArr[2]);
            return Convert.ToString(BinaryArr[0], 2) + "-" + Convert.ToString(BinaryArr[1], 2) + "-" +         Convert.ToString(BinaryArr[2], 2);
       }
}