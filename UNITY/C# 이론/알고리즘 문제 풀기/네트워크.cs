using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        int[] isVisited = new int[n];
        List<int> next = new List<int>();
        
        while(isVisited.Contains(0)) //isVisited가 모두 1일 때 까지
        {
            if(next.Count == 0)
            {
                for(int i = 0; i< n; i++)
                {
                    if(isVisited[i] == 0)
                     {   
                         next.Add(i);
                         answer++;
                         break;
                     }
                }
            }
            int now = next[0];
            //n행 부터 방문
            for(int i = 0; i<n; i++)
            {
                if(now == i)
                    isVisited[i] = 1;
                if(isVisited[i]== 0)
                {
                    isVisited[i] = 1;
                    next.Add(i);
                }
                else
                {
                    continue;
                }
            }
            next.RemoveAt(0);
        }
        return answer;
    }
}