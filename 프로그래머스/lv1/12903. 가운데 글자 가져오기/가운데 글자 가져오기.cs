public class Solution 
{
    public string solution(string s) 
    {
        string answer;
        int j = s.Length;
        
        int num1;
        int num2;
        char index1;
        char index2;
        
        if(j % 2 == 0)
        {
            num1 = j / 2 - 1;
            num2 = j / 2;
            
            index1 = s[num1];
            index2 = s[num2];
            
            answer = index1.ToString() + index2.ToString();
        }
        else
        {
            num1 = j / 2;
            
            index1 = s[num1];
            answer = index1.ToString();
        }
        
        return answer;
    }
}