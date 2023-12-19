public class Solution 
{
    public string solution(int n) 
    {
        string answer = "";
        
        string su = "수";
        string bak = "박";

        for (int i = 0; i < n ; i++)
        {
            if (i % 2 == 0) // i 가 0 또는 짝수라면
            {
                answer += su;
            }
            else // i 가 홀수라면
            {
                answer += bak;
            }
        }
        return answer;
    }
}