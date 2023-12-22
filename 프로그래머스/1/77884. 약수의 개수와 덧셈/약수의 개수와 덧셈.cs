using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int left, int right) 
    {
        int answer = 0;
        List<int> intList = new List<int>();
        int yakNum = 0;
        
        // left 에서 right 범위 안에서
        for (int i = left; i <= right; i++)
        {
            // 약수 구해서 List 안에 넣기
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    intList.Add(j);
                }               
            }
            
            yakNum = intList.Count;
                    
            // 약수의 개수 짝, 홀 체크
            if (yakNum % 2 == 0) // 짝수라면
            {
                answer += i;
            }
            else // 홀수라면
            {
                answer -= i;
            }
            intList.Clear(); // List 비워주기
        }  
        
        return answer;
    }
}