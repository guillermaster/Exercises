using System;
// you can also use other imports, for example:
// using System.Collections.Generic;


// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        bool[] range = new bool[A.Length +1];
        
        for(int i=0; i<range.Length; i++){
            range[i] = false;
        }
        
        for(int i=0; i<A.Length; i++){
            if(A[i] > 0 && A[i] < range.Length){
                range[A[i] - 1] = true;
            }
        }
        
        for(int i=0; i<range.Length; i++){
            if(range[i] == false){
                return i + 1;
            }
        }
        return -1;
    }
}