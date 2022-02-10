using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        int[] answer = new int[] {};
        Dictionary<string, List<int>> song = new Dictionary<string, List<int>>();
        Dictionary<string, int> playCnt = new Dictionary<string, int>();
        
        for(int i = 0; i<genres.Length; i++)
        {
            if(!song.ContainsKey(genres[i]))
            {
               // List<int> newSong = new List<int>{i};
                song.Add(genres[i], new List<int> {i});
                playCnt.Add(genres[i], plays[i]);
            }
            else //이미 있다면
            {
                song[genres[i]].Add(i);
                playCnt[genres[i]] += plays[i];
            }
        }

        foreach(var v in song.Values)
        {
            v.Sort();
        }
       // song = song.OrderBy(x=>x.Value).ToDictionary(x=>x.Key, x=> x.Value);
        playCnt = playCnt.OrderBy(x=>x.Value).ToDictionary(x=>x.Key, x=> x.Value);
        
        foreach(var s in song.Values)
        {
            Console.WriteLine(s[0]);
        }
        return answer;
    }

    public void GetPriorG()
    {

    }

    public void GetPriorS()
    {

    }
}