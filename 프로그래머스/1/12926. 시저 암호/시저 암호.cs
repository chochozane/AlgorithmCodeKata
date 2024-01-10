public class Solution
{
    public string solution(string s, int n)
    {
        string answer = "";
        
        int charValue = 0;
        char[] chArr = s.ToCharArray();
        
        for (int i = 0; i < chArr.Length; i++)
        {
            // char - corresponding numeric value
            // 공백인 경우
            if (chArr[i] == ' ')
            {
                continue;
            }
            
            // 요소에 ascii value(int) 를 더하고
            charValue = (int)chArr[i] + n;
            
            // 조건문으로 소문자는 소문자 범위 내로 묶고, 대문자는 대문자 범위 내로 묶기
            if (chArr[i] >= 'a' && chArr[i] <= 'z')
            {
                if (charValue > 'z')
                {
                    charValue -= 26;
                }
            }
            else if (chArr[i] >= 'A' && chArr[i] <= 'Z')
            {
                if (charValue > 'Z')
                {
                    charValue -= 26;
                }
            }
            
            // 더한 그 값을 char 로 변환
            chArr[i] = (char)charValue;
        }
        
        answer = new string(chArr);
        return answer;
    }
}