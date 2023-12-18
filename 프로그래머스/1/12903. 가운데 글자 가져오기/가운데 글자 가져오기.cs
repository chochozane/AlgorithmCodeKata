public class Solution 
{
    public string solution(string s) 
    {       
        if (s.Length % 2 == 0) // 짝수라면
        {                
            char charFirstEven = s[(s.Length / 2) - 1];
            char charSecondEven = s[((s.Length / 2) + 1) - 1];
            return charFirstEven.ToString() + charSecondEven.ToString();
        }
        else // 홀수라면
        {    
            char charOdd = s[((s.Length / 2) + 1) - 1];
            return charOdd.ToString();
        }
    }
}