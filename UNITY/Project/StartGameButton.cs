using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //SceneManager 사용위해
using UnityEngine.UI;


public class StartGameButton : MonoBehaviour
{
 


    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void Button()
    {
      
            Invoke("startgame", .3f); // Invoke("실행함수", 지연시간)
        
                  
    }
    private void startgame()
    {
        SceneManager.LoadScene("SampleScene"); //다음으로 SampleScene 불러옴
    }
}
