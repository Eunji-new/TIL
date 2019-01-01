# UNITY 시작

### 기본적인 사용법
- Ctrl + F -> 그 오브젝트를 중심으로 볼수 있음

- 마우스 오른쪽 클릭, 드래그 -> 화면 돌림

- 처음 만들때 tranform 초기화

### 코드 
- 전처리부

- Start() <처음에 한번만 실행되는 함수> <start()와 다름!>

   this.gameObject.GetComponent<Transform>();
   -> GetComponent<Component>() 사용법

- Update()<1프레임마다 실행되는 함수><FixedUpdate와 구분>

     퍼블릭 변수는 바깥 컴포넌트에서 조정가능

     
## 방향키에 따라 움직이는 캡슐을 만들어봤다.

1. plane(0,0,0), capsule(0,1,0) 설정
2. capsule Object에 component 추가
3. C# 코드 작성
4. 실행 -> 정상실행됨

- 우선은 그다지 길지 않은 코드니까 첨부함


using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Ctr : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float moveRot = 0.5f;
    private Transform tr = null;

    // Start is called before the first frame update
    void Start()
    {
        tr = this.gameObject.GetComponent<Transform>(); //Transform에 tr로 간단하게 접근가능
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){ 
            tr.Translate(Vector3.left * moveSpeed * Time.deltaTime);//왼쪽(x축 -)
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tr.Translate(Vector3.right * moveSpeed * Time.deltaTime); // 오른쪽(x축 +)
        }
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            tr.Translate(Vector3.forward * moveSpeed * Time.deltaTime);// 위(z축 +)
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            tr.Translate(Vector3.back * moveSpeed * Time.deltaTime);// 아래(z축 -)
        }
    }
}

