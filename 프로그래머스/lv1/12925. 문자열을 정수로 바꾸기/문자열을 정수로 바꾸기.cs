public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        bool plus = s.Contains("+");
        bool minus = s.Contains("-");
        
        if(plus == true)
        {
            s = s.Replace("+", "");
            answer = int.Parse(s);
        }
        else if(minus == true)
        {
            s = s.Replace( "-", "");
            answer = int.Parse(s)*(-1);
        }
        else
        {
            answer = int.Parse(s);
        }
        
        return answer;
    }
}