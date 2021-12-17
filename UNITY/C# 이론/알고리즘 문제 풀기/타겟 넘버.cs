using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int target) {
        int answer = 0;
        List<int> curr = new List<int>(){0};
        List<int> next = new List<int>();
        foreach(int n in numbers)
        { 
            foreach(int c in curr)
            {
                next.Add(c+n);
                next.Add(c-n);
            }

            curr = new List<int>(next);
            //next = new List<int>(); //List의 초기화(비움)에는 Clear함수가 낫겠다.
            next.Clear(); 
        }
        
        foreach(int i in curr)
        { 
            //Console.WriteLine(i);
            if(target == i)
                answer++;
        }
        
        return answer;
    }
}