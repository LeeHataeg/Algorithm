public class Solution 
{
    public int[] solution(int n, int m)
    {
        int temp;
        int max = 2;
        int[] answer = new int[2];
        
        if(m > n)
        {
            temp = n;
            n = m;
            m = temp;
        }
        
        for(int i = 1; i <= m; i++)
        {
            if(n % i == 0 && m % i == 0)
            {
                max = i;
                answer[0] = max;
            }
        }
        
        for(int k = m; k <= m*n; k++)
        {
            if(k % n == 0 && k % m == 0)
            {
                answer[1] = k;
                break;
            }
        }
        
        return answer;
    }
}