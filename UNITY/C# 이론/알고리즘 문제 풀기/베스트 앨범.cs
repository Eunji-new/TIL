using System;

public class Solution {
    public int[] solution(string[] genres, int[] plays) {
        int[] answer = new int[] {};
        Dictionary<string, List<int>> song = Dictionary<string, List<int>>();
        
        for(int i = 0; i<genres.Count; i++)
        {
            if(!song.ContainsKey(genres[i]))
            {
                song.Add(genres[i], {i});
            }
            else //이미 있다면
            {
                song[genres[i]].Add(i);
            }
        }

        
        return answer;
    }
}