using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int totZeros = 0;
        int tot = 0;
        int max = 1000000000;
        
        foreach(int car in A){
            if(car==0){
                totZeros += 1;
            }
            else if(car==1){
                tot += totZeros;
            }
            if(tot > max){
                return -1;
            }
        }
        
        return tot;
    }
}