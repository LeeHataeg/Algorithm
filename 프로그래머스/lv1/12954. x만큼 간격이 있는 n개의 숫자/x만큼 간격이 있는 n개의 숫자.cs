public class Solution 
{
    public long[] solution(int x, int n) 
    {
        long[] answer = new long[n];
        
        long value_X = x;
        long value_N = n;
        
        for(long i = 0; i < value_N ; i++)
        {
            answer[i] = value_X * (i + 1);
        }
        
        return answer;
    }
}