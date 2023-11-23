using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        string str = n.ToString(); // int 를 string 으로 변환
        
        // string 의 index 길이 만큼 반복해서 char 를 string 으로 바꿔주고 최종적으로 int 로 변환 !
        for (int i = 0; i < str.Length; i++){            
            answer = int.Parse(str[i].ToString()) + answer;
        }
        return answer;
    }
}