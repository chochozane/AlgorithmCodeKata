using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if (n >= 3 && n <= 1000000)
        {
            for (int x = 1; x < n; x++)
            {
                if (n % x == 1)
                {
                    answer = x;
                    break;
                }
            }
        }
        return answer;
    }
}