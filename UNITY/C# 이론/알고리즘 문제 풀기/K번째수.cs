using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[] {};
        List<int> result = new List<int>();
        //배열 자르기
        for(int i = 0; i < commands.GetLength(0); i++)
        {
             //배열 정렬하기
            int[] sortArr = GetArrayPart(array, commands[i,0], commands[i,1]);
            Array.Sort(sortArr);
             //k번째 숫자 구하기
            //Console.WriteLine(sortArr[0]);
            result.Add(sortArr[commands[i,2]-1]);
        }
        answer = result.ToArray();
        return answer;
    }
    
    int[] GetArrayPart(int[] array, int start, int end)
    {
        int[] newArr = new int[]{};
        List<int> l = new List<int>();
        int cnt = end-start+1;
        for(int i = 0; i<cnt; i++)
        {
             newArr = (newArr?.Concat(new int[] { array[start-1+i] }) ?? new int[] { array[start-1+i] }).ToArray(); //null이 아니면 새 원소 합치고, null 이면 새 원소로 할당 
           // l.Add(array[start-1+i]);
        }
        return newArr;
    }

}

//두번째 풀이 - 리스트 할당 후, 배열로 변경

/*
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[] {};
        List<int> result = new List<int>();
        //배열 자르기
        for(int i = 0; i < commands.GetLength(0); i++)
        {
             //배열 정렬하기
            int[] sortArr = GetArrayPart(array, commands[i,0], commands[i,1]);
            Array.Sort(sortArr);
             //k번째 숫자 구하기
            //Console.WriteLine(sortArr[0]);
            result.Add(sortArr[commands[i,2]-1]);
        }
        answer = result.ToArray();
        return answer;
    }
    
    int[] GetArrayPart(int[] array, int start, int end)
    {
        int[] newArr = new int[]{};
        List<int> l = new List<int>();
        int cnt = end-start+1;
        for(int i = 0; i<cnt; i++)
        {
            // newArr = (newArr?.Concat(new int[] { array[start-1+i] }) ?? new int[] { array[start-1+i] }).ToArray(); //null이 아니면 새 원소 합치고, null 이면 새 원소로 할당 
            l.Add(array[start-1+i]);
        }
        return l.ToArray();
    }


}
*/