using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int answer = 0;
        
        int wNum = 0;
        int hNum = 0;
        int max_FRow = 0;
        int max_SRow = 0;
        
        // 배열.Length - 배열 요소의 개수
        // 배열.GetLength(0) - 행의 길이
        // 배열.GetLength(1) - 열의 길이
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            wNum = sizes[i, 0];
            hNum = sizes[i, 1];
            
            // 같은 행에서 0 1 비교해서 큰 수가 0 으로 가도록
            if (wNum < hNum)
            {
                wNum = sizes[i, 1];
                hNum = sizes[i, 0];
            }
                
            // (가로 길이) - 가장 큰 값 get
            if (wNum > max_FRow)
            {  
                max_FRow = wNum;
            }
 
            // (세로 길이) - 가장 큰 값 get                
            if (hNum > max_SRow)
            {
                max_SRow = hNum;
            }                      
        }
        
        answer = max_FRow * max_SRow;
        return answer;
    }
}