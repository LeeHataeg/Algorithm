using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        int sum = 0;
        foreach(int n in numbers)
            sum += n;
        int answer = 45 - sum;
        return answer;
    }
}