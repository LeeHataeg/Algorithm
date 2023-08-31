using System;

public class Solution 
{
    public long solution(long n) 
    {
        var sqrtNum = Math.Sqrt(n);
        
        if(sqrtNum - (long)sqrtNum == 0)
        {
            long answer = (long)sqrtNum;
            answer += 1;
            answer *= answer;
            return answer;
        }
        else
        {
            return -1;
        }
    }
}