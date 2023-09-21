using System;

public class Solution 
{
    public int solution(string t, string p) 
    {
        int answer = 0;
        long numP = long.Parse(p);
        
        for(int index = 0; index <= t.Length - p.Length; index++)
        {
            if(t[index] < p[0])
            {
                answer++;
            }
            else if(t[index] == p[0])
            {
                string strNum = t.Substring(index, p.Length);
            	long numT = long.Parse(strNum);
                
            	if(numT <= numP)
            	{
                	answer++;
            	}
            }
        }
        
        return answer;
    }
}