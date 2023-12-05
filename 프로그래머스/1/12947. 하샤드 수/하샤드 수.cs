public class Solution {
    public bool solution(int x)
    {
        bool answer = true;
        
        //int 를 string 으로 + 그리고 char Array 로
        char[] chArr = x.ToString().ToCharArray();

        //char Array 를 string Array 로 + 그리고 int Array 로
        int[] intArr = new int[chArr.Length];
        for (int i = 0; i < chArr.Length; i++)
        {
            intArr[i] = int.Parse(chArr[i].ToString());
        }
        
        // int Array 요소들을 더해서 x 의 자릿수 합으로 x 가 나눠지는지 체크
        int sum = 0;
        foreach(int num in intArr)
        {
            sum += num;
        }
        
        if(x % sum == 0)
        {
            answer = true;
        }
        else answer = false;
                
        return answer;
    }
}