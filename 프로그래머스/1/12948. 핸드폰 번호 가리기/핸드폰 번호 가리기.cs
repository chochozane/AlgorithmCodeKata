public class Solution 
{
    public string solution(string phone_number) 
    {
        string answer = "";
        
        string[] strArr = new string[phone_number.Length];
        
        for(int i = 0; i < phone_number.Length; i++)
        {
            if (i < phone_number.Length - 4)
            {
                strArr[i] = "*";
            }
            else
            {
                strArr[i] = phone_number[i].ToString();
            }            
        }
        
        answer = string.Join("", strArr);
        
        return answer;
    }
}