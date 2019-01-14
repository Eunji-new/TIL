# 프로젝트

앞으로 자동으로 가면서 방향키로 장애물 피하기...

## C# 스크립트 코드

using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Main_Capsule_Controller : MonoBehaviour
{
    
    public float moveSpeed = 5.0f;
    private Transform character = null;
    // Start is called before the first frame update
    void Start()
    {
        character = this.gameObject.GetComponent<Transform>(); //메인 캡슐 캐릭터
    }

    // Update is called once per frame
    void Update()
    {
        character.Translate(Vector3.forward * moveSpeed * Time.deltaTime); //무조건 앞으로 이동함

        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 방향키는 왼쪽
        { 
            character.position = new Vector3(-4, 0, moveSpeed * Time.deltaTime);
         }

        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽 방향키는 오른쪽
        {
            character.position = new Vector3(4, 0, moveSpeed * Time.deltaTime);
        }

    }
}
