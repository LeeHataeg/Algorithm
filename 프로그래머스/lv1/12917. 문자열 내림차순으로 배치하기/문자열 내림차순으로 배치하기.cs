using System.Collections;
using System.Collections.Generic;
public class Solution 
{
    public string solution(string s) 
    {
        List<char> smallStr = new List<char>();
        List<char> bigStr = new List<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] >= 'A' && s[i] <= 'Z')
                bigStr.Add(s[i]);
            else
                smallStr.Add(s[i]);
        }
        
        bigStr.Sort();
        smallStr.Sort();
        bigStr.Reverse();
        smallStr.Reverse();
        
        string answer = "";
        
        foreach(char c in smallStr)
            answer += c.ToString();
        
        foreach(char c in bigStr)
            answer += c.ToString();
        
        return answer;
    }
}