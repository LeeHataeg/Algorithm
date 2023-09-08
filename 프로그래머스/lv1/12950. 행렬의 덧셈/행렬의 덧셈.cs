public class Solution 
{
    public int[,] solution(int[,] arr1, int[,] arr2) 
    {
        int i = arr1.GetLength(0);
        int j = arr1.GetLength(1);
        int[,] answer = new int[i,j];
        
        for(int p = 0; p < i; p++)
        {
            for(int t = 0; t < j; t++)
            {
                answer[p,t] = arr1[p,t] + arr2[p,t];
            }
        }
        return answer;
    }
}