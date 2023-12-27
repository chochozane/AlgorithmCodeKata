public class Solution
{
    public bool solution(string s) 
    {
        bool answer = true;
        
        if (s.Length == 4 || s.Length == 6) // 길이가 4 혹은 6 인 경우
        {
            // 숫자로만 구성되어있는지 체크
            foreach (char ch in s)
            {
                if(ch >= '0' && ch <= '9') // 숫자로만 구성되어있다면
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    break;
                }
            }
        }
        else // 길이가 4 혹은 6 이 아닌 경우
        {
            answer = false;
        }
        return answer;
    }
}