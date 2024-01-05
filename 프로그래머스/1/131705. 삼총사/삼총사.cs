using System;

public class Solution 
{
    public int solution(int[] number) 
    {
        int answer = 0;     

        // 3명 의 정수 번호 더했을 때 0 이 되면 삼총사
        //서로 다른 학생의 정수 번호가 같을 수 있다.
        // 3명씩 묶어 더한 값이 0
     
        for (int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++)
            {
                for (int k = j + 1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
}