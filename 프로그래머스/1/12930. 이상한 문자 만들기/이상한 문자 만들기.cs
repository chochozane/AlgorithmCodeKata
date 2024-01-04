using System;

public class Solution
{
    public string solution(string s) 
    {
        string answer = "";

        // Split
        string[] strSplit = s.Split(' ');
        
        // 배열의 Length
        for (int i = 0; i < strSplit.Length; i++)
        {
            // 배열 요소 string 의 Length
            for (int j = 0; j < strSplit[i].Length; j++)
            {
                if (j == 0 || j % 2 == 0)
                {
                    // char - ToUpper
                    answer += Char.ToUpper(strSplit[i][j]);
                }
                else
                {
                    // char - ToLower
                    answer += Char.ToLower(strSplit[i][j]);
                }
            }
            // 배열 하나의 요소 끝날 때 띄어쓰기 추가 - 마지막은 띄어쓰기 추가하면 안 되기에 -1
            if (i != strSplit.Length - 1)
            {
                answer += " ";
            }
        }
        
        return answer;
    }
}