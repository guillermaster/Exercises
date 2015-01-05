// you can also use imports, for example:
// import java.util.*;

// you can use System.out.println for debugging purposes, e.g.
// System.out.println("this is a debug message");

/*
Write a function:
class Solution { public int solution(int A, int B, int K); }
that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:
{ i : A ¡Ü i ¡Ü B, i mod K = 0 }
For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range [6..11], namely 6, 8 and 10.
Assume that:
A and B are integers within the range [0..2,000,000,000];
K is an integer within the range [1..2,000,000,000];
A ¡Ü B.
Complexity:
expected worst-case time complexity is O(1);
expected worst-case space complexity is O(1).
*/

class CountDiv {
    public int solution(int A, int B, int K) {
        // write your code in Java SE 8
        int skip;
        if (A % K == 0) {
            skip = 0;
        } 
        else {
            skip = K - A % K;
            if (B < A + skip) {
                return 0;
            }
        }
        
        return 1 + ((B - A -skip) / K);
    }
}