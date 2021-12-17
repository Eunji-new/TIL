using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;//
        Dictionary<string, List<string>> ClothPair = new Dictionary<string, List<string>>();
        Dictionary<string, int> ClothCnt = new Dictionary<string, int>();
        for(int i = 0; i< clothes.GetLength(0); i++)
        {
            //의상 종류 안가지고 있으면 키 추가
            if(!ClothPair.ContainsKey(clothes[i,1]))
            {    
                ClothPair.Add(clothes[i,1], new List<string>());
                ClothPair[clothes[i,1]].Add(clothes[i,0]);
                ClothCnt.Add(clothes[i,1], 1);
            }
            else
            {
                ClothPair[clothes[i,1]].Add(clothes[i,0]);
                ClothCnt[clothes[i,1]]++;
            }
        }
        
        /*
        ( ( 외투의 갯수 + 1 ) * ( 모자의 갯수 + 1 ) * ( 안경의 갯수 + 1 ) ) - 1

        모든 경우의 수를 구할 경우 각 종류의 갯수를 곱해주면 되지만,

        해당 옷의 종류를 선택하지 않을 경우를 포함하기 떄문에 종류의 갯수에 +1 을 해주고

        아무것도 선택하지 않는 경우는 없기 때문에 마지막에 -1
        */
        List<int> cnt = ClothCnt.Values.ToList();
        for(int i = 0; i< cnt.Count; i++)
        {
            answer *= (cnt[i]+1);
        }
        
        return answer - 1;
    }
}