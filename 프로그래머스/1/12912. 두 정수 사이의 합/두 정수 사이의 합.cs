public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        
        // a 와 b 사이 값을 얻으려면 반복문 돌리기
        // 반복문 돌리기 전에 a 와 b 중에 누가 더 작고 큰지를 알아야 한다
        
        if (a > b)
        {
            for (int i = b; i <= a; i++)
            {
                answer += i;
            }
        }
        else if (a < b || a == b)
        {
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
        }        
        return answer;
    }
}