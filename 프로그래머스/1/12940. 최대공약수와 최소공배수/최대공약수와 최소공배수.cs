using System;

public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];
        int max = 0;
        int min = 0;
        
        max = getGCD(n, m); // 최대공약수
        min = (n * m) / max; // 최소공배수 -> 두 자연수의 곱 나누기 최대공약수
        
        answer[0] = max;
        answer[1] = min;
        return answer;
    }
    
    // 최대공약수 재귀 함수. 유클리드 호제법
    // GCD = Greatest Common Divisor
    public int getGCD(int a, int b)
    {
        if (b == 0) // 나머지가 0 인 경우 현재 몫이자 최대공약수인 a 리턴
        {
            return a;
        }   
        else // 나머지가 0 이 아니면
        {
            return getGCD(b, a % b);
        }  
    }
}