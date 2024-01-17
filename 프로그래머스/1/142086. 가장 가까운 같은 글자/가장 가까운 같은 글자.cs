using System;
using System.Linq; 

public class Solution
{
    public int[] solution(string s) 
    {
        int[] answer = new int[s.Length];
        char[] charArr = new char[s.Length];
        int index = 0;
        int sub = 0;
        
        // s 길이 만큼 for loop 돌기
        for (int i = 0; i < s.Length; i++)
        {
            // 배열에 중복 글자가 있는지 체크 - Contains
            if (charArr.Contains(s[i])) // 중복 있으면 몇칸 앞에 있는지 수를 리턴
            {
                // 중복 글자가 여러 개 있다면 나랑 가까운 인덱스 있는걸 델꼬 와야함 !!!! 
                index = Array.LastIndexOf(charArr, s[i]); // Array.IndexOf 사용하면 안될듯 / LastIndexOf 도전
                sub = i - index;
                answer[i] = sub;
                charArr[i] = s[i];
            }
            else // 중복 없으면 -1 리턴
            {
                answer[i] = -1;
                charArr[i] = s[i];
            }                       
        }
        
        return answer;
    }
}