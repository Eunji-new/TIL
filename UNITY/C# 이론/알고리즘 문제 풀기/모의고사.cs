using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        int[] replay1 = new int[]{1,2,3,4,5};
        int[] replay2 = new int[]{2,1,2,3,2,4,2,5};
        int[] replay3 = new int[]{3,3,1,1,2,2,4,4,5,5};
        int[] correctNum = new int[]{0,0,0};
        for(int idx = 0; idx<answer.Length; i++)
        {    
            //1번
            if(answer[idx] == replay1[idx%replay1.Length]){
                correctNum[0]++;
            }
            //2번
            if(answer[idx] == replay2[idx%replay2.Length]){
                correctNum[1]++;
            }
            //3번
            if(answer[idx] == replay3[idx%replay3.Length]){
                correctNum[2]++;
            }
        }
        int min = correctNum[0];
        int max = 0;
        int maxIdx = 0;
        for(int i = 0; i<correctNum.Length; i++){
            if(min>correctNum[i])
            {  
                min = correctNum[i];
            }
            if(max<=correctNum[i])
            { 
                max = correctNum[i];
                maxIdx = i+1;
            }
        }
        answer = (answer?.Concat(new int[]{maxIdx}))?? new int[]{maxIdx};
        //같은게 있는지 검사
        for(int i = 0; i<correctNum.Length; i++){
            if(i!=maxIdx-1 && correctNum[i] == max)
                answer = answer.Concat(new int[]{i+1});
        }
        return answer;
    }
}