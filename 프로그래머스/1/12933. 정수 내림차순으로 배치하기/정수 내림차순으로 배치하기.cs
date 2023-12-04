using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;

        // long n -> string
        string longToStr = n.ToString();
        // string -> char array
        char[] strToChArr = longToStr.ToCharArray();

        // long Array 만들기
        long[] longArr = new long[strToChArr.Length];

        // char array 의 index 만큼 돌면서 string 으로 변환 후 long 로 변환
        for (int i = 0; i < strToChArr.Length; i++)
        {
            longArr[i] = long.Parse(strToChArr[i].ToString());
        }

        // long Array 를 오름차순으로
        Array.Sort(longArr);
        // 오름차순을 뒤집기(내림차순이 되겠죠)
        Array.Reverse(longArr);

        // long Array 를 string Array 로 변환
        string[] longToStrArr = new string[longArr.Length];

        for (int i = 0; i < longArr.Length; i++)
        {
            longToStrArr[i] = longArr[i].ToString();
        }

        // string Array 를 string 으로        
        string strArrToStr = string.Join("", longToStrArr);

        long strTolong = long.Parse(strArrToStr);

        answer = strTolong;

        return answer;
    }
}