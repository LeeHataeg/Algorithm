using System;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        
        while(true)
        {
            if(n < 10)
            {
                answer += n % 10;
                return answer;
            }
            else
            {
                answer += n % 10;
                n /= 10;
            }
        }
    }
}