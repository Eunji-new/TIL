# 프로젝트

앞으로 자동으로 가면서 방향키로 장애물 피하기...

## C# 스크립트 코드

 - 190114 ) 방향키를 너무 예민하게 잘받아서 극단적으로 이동함;;


using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Main_Capsule_Controller : MonoBehaviour
{

   public float moveSpeed = 5.0f;
    public float gap = 4f; //왼,중,오 간격
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
            if(character.position.x == gap) //현재 오른쪽이면
             character.position = new Vector3(0, 0, moveSpeed * Time.deltaTime); //중앙으로
            else if (character.position.x == 0) //현재 중앙이면
                character.position = new Vector3(-gap, 0, moveSpeed * Time.deltaTime); //왼쪽으로
        }

        if (Input.GetKey(KeyCode.RightArrow)) // 오른쪽 방향키는 오른쪽
        {

            if (character.position.x == -gap) //현재 왼쪽이면
                character.position = new Vector3(0, 0, moveSpeed * Time.deltaTime); //중앙으로
            else if (character.position.x == 0) //현재 중앙이면
                character.position = new Vector3(gap, 0, moveSpeed * Time.deltaTime); //오른쪽으로
        }

    }
}
