using System;

public class Solution {
    public int[] solution(long n) {
        int[] answer;

        // int 를 string 으로
        string intToStr = n.ToString();

        // string 을 char array 로
        char[] ch = intToStr.ToCharArray();

        // ch array 를 뒤집기
        Array.Reverse(ch);

        // char array 를 string array 로
        string[] strArr = new string[ch.Length];

        for (int i = 0; i < ch.Length; i++)
        {
            strArr[i] = ch[i].ToString();
        }

        // string array 를 int array 로
        answer = new int[strArr.Length];

        for (int i = 0; i < strArr.Length; i++)
        {
            answer[i] = int.Parse(strArr[i]);
        }
            return answer;
    }
    
}