public class Solution 
{
    public long solution(int a, int b) 
    {
        long answer = 0;
        long biggerNum;
            
        if(a > b)
        {
            for(long i = b; i <= a; i++)
            {
                answer += i;
            }
        }
        else if(a==b)
        {
            answer = a;
        }
        else
        {
            for(long i = a; i <= b; i++)
            {
                answer += i;
            }
        }
        return answer;
    }
}