using System;

public class Solution 
{
    public int solution(int[] number) 
    {
        int answer = 0;
        
        for(int index = 0; index < number.Length - 2; index++)
        {
            for(int i = index + 1; i < number.Length - 1; i++)
            {
                for(int j = i + 1; j < number.Length; j++)
                {
                    if(number[index] + number[i] + number[j] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
}