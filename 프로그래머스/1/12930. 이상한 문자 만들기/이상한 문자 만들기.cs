public class Solution
{
    public string solution(string s) 
    {
        string answer = "";
        
        string[] sSplit = s.Split(" ");
        int sLength = sSplit.Length;
        
        for( int index = 0; index < sLength; index++ )
        {
            int stringLength = sSplit[index].Length;
            
            for(int indexK = 0; indexK < stringLength; indexK++)
            {
                answer += (indexK % 2 == 0) ? sSplit[index][indexK].ToString().ToUpper() : sSplit[index][indexK].ToString().ToLower();
            }
            
            if(index != sLength - 1)
                answer += " ";
        }
        
        
        return answer;
    }
}