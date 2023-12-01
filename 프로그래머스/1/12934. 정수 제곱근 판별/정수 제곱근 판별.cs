public class Solution {
    public long solution(long n) {
        long answer = 0;
                
        // x 에 계속 +1 하면서 n 이 x * x 인 순간 return x+1 의 제곱 하도록 !
        for (long x = 1; x <= n; x++)
        {
            if (x * x == n)
            {
                answer = (x + 1) * (x + 1);
                break; // for문 탈출
            }
            else if (x * x > n)
            {
                return -1;
            }             
        }
            return answer;
        }        
    }