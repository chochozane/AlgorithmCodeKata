using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] a, int[] b) 
    {
        int answer = 1234567890;
        List<int> intList = new List<int>();
        
        for (int i = 0; i < a.Length; i++)
        {
            intList.Add(a[i]*b[i]);
        }
        
        int sum = 0;
        foreach (int num in intList)
        {
            sum += num;
        }
        
        answer = sum;       
        return answer;
    }
}