using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalPrice = 0;
		
		for(long i = 0; i < count; i++)
		{
    		totalPrice += (long)price * (i + 1);
		}
		
        long num = 0;
        
		if(totalPrice > money)
		{
            num = (long)totalPrice - (long)money;
		}
        
        return num;
    }
}