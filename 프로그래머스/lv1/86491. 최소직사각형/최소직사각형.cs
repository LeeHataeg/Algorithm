using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int answer = 0;
        int answerH = 0;
        int answerV = 0;
        
        for(int index = 0; index < sizes.Length / 2; index++)
        {
            if(sizes[index, 0] > sizes[index, 1])
            {
                if(answerH < sizes[index, 0])
                {
                    answerH = sizes[index, 0];
                }
                
                if(answerV < sizes[index, 1])
                {
					answerV = sizes[index, 1];
                }
            }
            else
            {
                if(answerV < sizes[index, 0])
                {
                    answerV = sizes[index, 0];
                }
                
                if(answerH < sizes[index, 1])
                {
					answerH = sizes[index, 1];
                }
            }
        }
        
        return answer = answerH*answerV;
    }
}