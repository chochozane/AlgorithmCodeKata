using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = -1;
        int sum = 0;
    
        for (int i = 0; i < 10; i++) // 0 ~ 9 돌기
        {
            bool hasNum = false;
    
            for (int j = 0; j < numbers.Length; j++)
            {
                if (i == numbers[j]) 
                {
                    hasNum = true;
                    break;
                }
            }
    
            if (!hasNum) 
            {
                sum += i;
            }
        }
        
        answer = sum;
        return answer;
    }
}