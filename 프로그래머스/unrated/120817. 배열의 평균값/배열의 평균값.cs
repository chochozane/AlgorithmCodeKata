using System;

public class Solution {
    public double solution(int[] numbers)
    {
        double answer = 0;
        int sum = 0;
        
        for (int i = 0; i < numbers.Length; i++){
            sum = (numbers[i] + sum); 
        }
        
        answer = (double)sum / numbers.Length;
        
        return answer;
    }
}