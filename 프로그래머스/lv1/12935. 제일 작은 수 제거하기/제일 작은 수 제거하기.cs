public class Solution 
{
    public int[] solution(int[] arr) 
    {
        int arrLength = arr.Length - 1;
        
        if(arr.Length == 1)
        {
            int[] answer = new int[1];
            answer[0] = -1;
            return answer;
        }
        
        else
        {
            int[] answer = new int[arrLength];
        	int min = 0;
            int minValue = arr[0];
            int k = 0;
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(minValue > arr[i])
                {
                    minValue = arr[i];
                    min = i;
                }
            }
            for(int j = 0; j < arr.Length; j++)
            {
                if(j == min)
                {
                    continue;
                }
                else
                {
                    answer[k] = arr[j];
                    k++;
                }
            }
            
            return answer;
        }
    }
}