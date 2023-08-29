using System;
public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        int count = HowManyDigit(n);
        int[] downArray = new int[count];
        long temp;
        int empty;
        int sub;
        for(int i = 0;i < count; i++)
        {
            temp = n % 10;
            downArray[i] = (int)temp;
            n /= 10;
        }
        Array.Sort(downArray);
        Array.Reverse(downArray);
        
        temp = 1;
        for(int k = 0; k < count; k++)
        {
            answer += (long)(downArray[count -1 -k] * temp);
            temp *= 10;
        }
        return answer;
    }
    public int HowManyDigit(long n)
    {
        int count = 0;
        while(n > 10)
        {
            n /= 10;
            count ++;
        }
        count++;
        return count;
    }
}