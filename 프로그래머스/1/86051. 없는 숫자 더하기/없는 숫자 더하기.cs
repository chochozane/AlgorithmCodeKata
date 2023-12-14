using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = -1;
        int addOneToNine = 0;
        int sumIntArr = 0;
        
        for(int i = 0; i < 10; i++)
        {
            addOneToNine += i;
        }
        
        foreach (int num in numbers)
        {
            sumIntArr += num;
        }
        
        answer = addOneToNine - sumIntArr;
        
        return answer;
    }
}