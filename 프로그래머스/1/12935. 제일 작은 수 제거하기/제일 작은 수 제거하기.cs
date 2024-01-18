using System.Linq;

public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int[] answer = new int[] {};
        
        // arr 의 요소가 1개일 때
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }
        
        // arr 의 요소가 2개 이상일 때 -- Array.Min() - 최솟값 찾기
        int min = arr.Min();
        answer = arr.Where(x => x != min).ToArray();

        return answer;
    }
}