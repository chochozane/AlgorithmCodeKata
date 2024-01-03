using System;
using System.Collections.Generic;
using static System.Math;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        List<int> toTernaryList = new List<int>();
        
        // 10진법을 3진법으로
        while (n > 0)
        {
            toTernaryList.Add(n % 3);
            n /= 3;      
        }
        
        // 3진법 앞뒤 반전
        toTernaryList.Reverse();
        
        // 3진법을 10진법으로
        for (int i = 0; i < toTernaryList.Count; i++)
        {
            // Math.Pow 의 리턴값은 double
            answer += (toTernaryList[i] * (int)Math.Pow(3, i));
        }
        
        return answer;
    }
}