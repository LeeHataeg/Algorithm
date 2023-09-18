public class Solution {
    public int[] solution(int n, int m) {
            int[] answer = new int[2];

            int 최대공약수 = 1;
            int 최소공배수 = 0;

            for (int i = 2; i < n + 1; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    최대공약수 = i;
                }
            }

            for (int j = 1; j < int.MaxValue / m; j++)
            {
                if ((m * j) % n == 0)
                {
                    최소공배수 = m * j;
                    break;
                }
            }

            answer[0] = 최대공약수;
            answer[1] = 최소공배수;

            return answer;
    }
}