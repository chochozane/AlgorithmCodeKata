using System;

public class Solution
{
    public string[] solution(string[] strings, int n)
    {
        string[] answer = new string[strings.Length];
        
        // n 번째 문자를 앞에 더한 문자열
        for (int i = 0; i < strings.Length; i++)
        {
            answer[i] = strings[i][n] + strings[i];
        }
        
        // 오름차순으로
        Array.Sort(answer);
        
        // 앞에 더한 문자 삭제
        // .Substring(시작위치index) - 시작위치부터 끝까지의 문자열 반환
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = answer[i].Substring(1);
        }
        
        return answer;
    }
}