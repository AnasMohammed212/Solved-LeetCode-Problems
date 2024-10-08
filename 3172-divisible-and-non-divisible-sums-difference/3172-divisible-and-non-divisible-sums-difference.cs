public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int DivisibleNumbers = 0, NonDivisibleNumbers = 0;
for (int i = 1; i <= n; i++) {
    if (i % m == 0)
        DivisibleNumbers+=i;
    else
        NonDivisibleNumbers += i;
        }
return NonDivisibleNumbers- DivisibleNumbers;
    }
}