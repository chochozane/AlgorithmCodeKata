using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 123456789;
        List<int> numbers = new List<int>();
        
        for (int i = 0; i < absolutes.Length; i++)
        {
            if(signs[i] == true)
            {
                numbers.Add(absolutes[i] * 1);
            }
            else // signs[i] == false 이면
            {
                numbers.Add(absolutes[i] * -1);
            }            
        }
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        answer = sum;
        return answer;
    }
}