using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csButton : MonoBehaviour
{
   
    public Text startGame;

   

    // Start is called before the first frame update
    void Start()
    {

        startGame.text = "Start Game";// text를 start game으로 바꿈
       // startGame.GetComponent<Text>().text = "Start Game";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
