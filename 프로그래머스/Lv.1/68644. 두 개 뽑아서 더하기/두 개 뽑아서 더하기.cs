using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers) 
    {
        int[] answer = new int[] {};
        List<int> intList = new List<int>();
        
        // 서로 다른 인덱스에 있는 두 개의 수 더해서 만들 수 있는 모든 수를 배열에 담자 !
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // 수가 중복된다면 패쓰 - continue
                if (intList.Contains(numbers[i] + numbers[j]))
                {   
                    continue;
                }
                
                intList.Add(numbers[i] + numbers[j]);
            }            
        }
        
        // 오름차순 - Sort
        intList.Sort();
        
        // list 를 array 로 변경
        answer = intList.ToArray();
        return answer;
    }
}