using System;

public class Solution 
{
    public int solution(string t, string p) 
    {
        int answer = 0;
        string output = "";
        
        // 배열 돌리기
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            output = t.Substring(i, p.Length);
            
            if (long.Parse(output) <= long.Parse(p))
            {
                answer++;
            }  
        }
        
        return answer;
    }
}