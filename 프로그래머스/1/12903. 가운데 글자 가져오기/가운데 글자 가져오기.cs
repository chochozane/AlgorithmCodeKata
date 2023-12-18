public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        
        if(s.Length % 2 == 0) // 길이가 짝수라면
        {
            answer = s.Substring((s.Length / 2) - 1, 2);
        }
        else // 길이가 홀수라면
        {
            answer = s.Substring((s.Length / 2), 1);
        }
        
        return answer;
    }
}