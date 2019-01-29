# 탱크 만들기

## CsTank.cs

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

        float keyMove = Input.GetAxis("Vertical");
        float keyRot = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * amtMove * keyMove); //이동
        transform.Rotate(Vector3.up * amtMove * keyRot); //회전
    }
}
