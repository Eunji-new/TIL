using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTank : MonoBehaviour
{
    int moveSpeed = 5; // 이동속도
    int rotSpeed = 120; //회전속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float amtMove = moveSpeed * Time.smoothDeltaTime;
        float amtRot = rotSpeed * Time.smoothDeltaTime;

        float keyMove = Input.GetAxis("Vertical"); //-1 ~ 1을 리턴(W, 상 키 -> 0~1, S, 하 키 -> -1 ~ 1)
        float keyRot = Input.GetAxis("Horizontal");//-1 ~ 1을 리턴(D, 우 키 -> 0~1, A, 좌 키 -> -1 ~ 1)
 

        transform.Translate(Vector3.forward * amtMove * keyMove); //이동
        transform.Rotate(Vector3.up * amtMove * keyRot); //회전
    }
}
