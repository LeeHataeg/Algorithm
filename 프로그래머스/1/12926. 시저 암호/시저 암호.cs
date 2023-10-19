public class Solution 
{
    
    public string solution(string s, int n) 
    {
        string answer = "";
        char ansTemp;
        int ask;
        for(int index = 0; index < s.Length; index++)
        {
            if(s[index] == ' ')
            {
                answer += " ";
            }
            else
            {
                ansTemp = s[index];
                ask = System.Convert.ToInt32(ansTemp);
                if(ask >= 65 && ask <= 90)
                {
                    ask = (ask + n > 90) ? ask + n - 26 : ask + n;
                }
                else if(ask >= 97 && ask <= 122)
                {
                    ask = (ask + n > 122) ? ask + n - 26 : ask + n;
                }
                ansTemp = (char)(ask);
                answer += ansTemp.ToString();
            }
            
        }
        return answer;
    }
}