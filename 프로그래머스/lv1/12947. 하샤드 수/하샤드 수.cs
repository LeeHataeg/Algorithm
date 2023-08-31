public class Solution 
{
    public bool solution(int x) 
    {
        bool answer;
        
        int hashNum = Hash(x);
        
        if(x % hashNum == 0)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        return answer;
    }
    
    public int Hash(int h)
    {
        int sum = 0;
        while(true)
        {
            sum += h % 10;
            h /= 10;
            
            if(h < 10)
            {
                sum += h % 10;
                return sum;
            }
        }
    }
}