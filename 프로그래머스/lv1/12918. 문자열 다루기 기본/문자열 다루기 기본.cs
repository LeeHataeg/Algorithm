public class Solution 
{
    public bool solution(string s) 
    {
        bool answer = false;
        int x;
        
        if(s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s, out x);
        }
        
        return answer;
    }
}