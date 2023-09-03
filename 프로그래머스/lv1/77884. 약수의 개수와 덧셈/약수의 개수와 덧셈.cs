using System;

public class Solution 
{
    public int solution(int left, int right) 
    {
        int answer = 0;
        for(int i = left; i <= right; i++)
        {
            double x = Math.Sqrt((double)i);
            bool isOdd = ((x % 2 == 0.0)||(x % 2 == 1.0))?true:false;
            
            if(isOdd)
                answer -= i;
            else
                answer += i;
        }
        return answer;
    }
}