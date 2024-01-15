using System;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];
        
        // array 를 i번째부터 j번째까지 겟 ! - for loop
        // 정렬하기 - Sort 사용하면 될듯
        // 정렬한 배열의 k 번째 수를 answer 배열에 담아 return
        
        for (int index = 0; index < commands.GetLength(0); index++)
        {
            // i 마다 i, j, k 원소 init
            int i = commands[index, 0];
            int j = commands[index, 1];
            int k = commands[index, 2];
            
            int[] output = new int[j - i + 1];
            
            for (int a = 0; a < output.Length; a++)
            {
                output[a] = array[a + i - 1];
            }
            
            Array.Sort(output);
            
            answer[index] = output[k - 1];
        }
        
        return answer;
    }
}