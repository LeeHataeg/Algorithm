using System;
using System.Linq;
public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        int count = 0;
        
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                count++;
            }
        }
        
        if(count == 0)
        {
            int[] answer = new int[] {-1};
            return answer;
        }
        else
        {
            int[] answer = arr.Where(x => x % divisor == 0).ToArray();
        	Array.Sort(answer);
            return answer;
        }
    }
}