using System;

public class Solution {
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[arr.Length];
        int count = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {            
            if (arr[i] % divisor == 0) // divisor 로 나누어 떨어질 때
            {
                answer[count] = arr[i];
                count++;
            }                      
        }
        
        // divisor 로 나누어 떨어지는 값이 없다면 -1 반환
        if(count == 0)
        {
            // answer 배열의 크기를 1 로 변경
            Array.Resize(ref answer, 1);
            answer[0] = -1;
        }
        else
        {
            // answer 배열의 크기를 count 로 변경
            Array.Resize(ref answer, count);
            Array.Sort(answer);
        }        
        return answer;     
    }
}