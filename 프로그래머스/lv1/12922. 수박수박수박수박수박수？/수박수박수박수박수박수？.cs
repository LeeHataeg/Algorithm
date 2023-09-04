public class Solution 
{
    public string solution(int n) 
    {
        string wMelon = "수박";
		string su = "수";
		string answer = "";
		for(int i = 0; i < n/2; i++)
    		answer += wMelon;
		
		if(n%2==1)
    		answer += su;
		
		return answer;
    }
}