public class Solution 
{
    public string solution(string phone_number) 
    {
        string answer = "";
        
        int count = phone_number.Length;
        string star = "";
        
        for(int i = 0; i< count - 4; i++)
        {
            star = star.Insert(0, "*");
        }
        
        answer = phone_number.Remove(0, count-4)
            				 .Insert(0, star);
        
        return answer;
    }
}