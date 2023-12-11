using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[] {};
        List<int> result = new List<int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                result.Add(arr[i]);
            }
        }
        
        if (result.Count == 0)
        {
            result.Add(-1);
        }
        
        // Sort()
        result.Sort();
        // ToArray()
        answer = result.ToArray();
        return answer;
    }
}