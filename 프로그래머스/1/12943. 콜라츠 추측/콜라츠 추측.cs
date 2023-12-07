public class Solution {
    public int solution(int num) {
        int answer = 0;
        long numLong = num; // num 이 반복을 돌다가 int 의 범위를 벗어나는 경우 있음.
        
        if (numLong == 1) 
        {
            return 0;
        }
        
        // 1이 될 때까지 반복한다
        while(numLong != 1)
        {
            // 입력된 수가 짝수라면 2로 나눈다
            if (numLong % 2 == 0)
            {
                numLong = numLong / 2;
                answer++;
            }
            // 입력된 수가 홀수라면 3을 곱하고 1을 더한다
            else if (numLong % 2 ==1)
            {                
                numLong = numLong * 3 + 1;
                answer++;            
            }
            
            if (answer >= 500)
            {
                return -1;
            }           
        }        
        return answer;
    }
}