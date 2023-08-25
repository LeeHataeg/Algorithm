public class Solution 
{
    public int[] solution(long n) 
    {
        long num = n;
        long temp;
        
        int count = HowManyDigit(num);
        
        int[] answer = new int[count];
        
        for(int i = 0; i < count; i++)
        {
            temp = num % 10;
            answer[i] = (int)temp;
            num /= 10;
        }
        
        return answer;
    }
    
    public int HowManyDigit(long num)
    {
        int count = 0;
        while(true)
        {
            if(num < 10)
            {
                count++;
                return count;
            }
            else
            {
              	num /= 10;
            	count++;  
            }
        }
    }
}