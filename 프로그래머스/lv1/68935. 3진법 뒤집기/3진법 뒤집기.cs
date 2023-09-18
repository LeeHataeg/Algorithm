using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        List<int> remain = new List<int>();
        int tempV = n;
        
        while(true)
        {
            if(tempV == 0)
            {
                break;
            }
            
            remain.Add(tempV % 3);
            tempV = tempV / 3;
        }
        
        int leng = remain.Count();
        remain.Reverse();
        int mult = 1;
       
        for(int index = 0; index < leng; index++)
        {
            if(index == 0)
            {
                answer += mult * remain[index];
            }
            else
            {
                mult *= 3;
                answer += mult * remain[index];
            }
        }
        
        return answer;
    }
}