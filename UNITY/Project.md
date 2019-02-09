# 프로젝트

앞으로 자동으로 가면서 방향키로 장애물 피하기...


## C# 스크립트 코드

 - 190114 ) 방향키를 너무 예민하게 잘받아서 극단적으로 이동함;;

 - 190115 ) GetKeyDown - 눌렀을때만....알던건데,,,,,,,,,,,,,이거떄문에 몇시간을,,,,,,,,,,,ㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷㄷㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷ한심..

 - 190117 ) tranlate(상대좌표 - 매 프레임마다 값만큼 이동)와 position(절대좌표 - 순간이동)의 차이! + Debug.log();

 - 190206 ) Collsion관련 이벤트함수가 안떠서 한동안 다른거 하다가 왔더니 뜬다..;;무엇..부딪히면 사라지는 것까지 처리. 

 -190207 ) 켑슐 position.x 가 언제부터인가 처음에 0으로 안뜬다..ㅜㅜㅜㅜㅜ

using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Main_Capsule_Controller : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float gap = 3f; //왼,중,오 간격
    private Transform character = null;
    public int life = 3; //생명 3개
    public Transform Barrel; // 배럴 프리팹
    public Transform Center;
    public Transform Right;
    public Transform Middle;
    public Transform Left;
    public int n = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        character = this.gameObject.GetComponent<Transform>(); //메인 캡슐 캐릭터
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Create_Barrel();
     
    } //Update

  void move() /
  /캐릭터 기본 이동
    {
        
        character.Translate(Vector3.forward * moveSpeed * Time.deltaTime); //무조건 앞으로 이동함
        Center.Translate(Vector3.forward * moveSpeed * Time.deltaTime); //무조건 가운데에 고정(left, middle, right 고정해줌)
       
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //왼쪽 방향키는 왼쪽
        {
            if (character.position.x  < 1 && character.position.x > -1) //현재 중앙이면
            {
                character.Translate(-gap, 0, moveSpeed * Time.deltaTime); //왼쪽으로

            }
            else if (character.position.x == gap) //현재 오른쪽이면
            {
                character.Translate(-gap, 0, moveSpeed * Time.deltaTime); //중앙으로
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) // 오른쪽 방향키는 오른쪽
        {
            if (character.position.x < 1 && character.position.x > -1) //현재 중앙이면
            {
                character.Translate(gap, 0, moveSpeed * Time.deltaTime); //오른쪽으로

            }
            else if (character.position.x == -gap) //현재 왼쪽이면
            {

                character.Translate(gap, 0, moveSpeed * Time.deltaTime); //중앙으로

            }
        }
    }

    void Create_Barrel() //배럴 랜덤생성
    {
        n++;
        if (n%40 == 0) //50프레임마다 한번씩...
        {
            int empty = (int)Random.Range(1, 4); //가는길에 Barrel 비워둘 곳.
          
            if (empty == 1) //왼쪽 비워놓기
            {
                Instantiate(Barrel, Middle.position, Quaternion.identity);
                Instantiate(Barrel, Right.position, Quaternion.identity);
            }
            else if (empty == 2)// 가운데 비워놓기
            {
                Instantiate(Barrel, Left.position, Quaternion.identity);
                Instantiate(Barrel, Right.position, Quaternion.identity);
            }
            else //오른쪽 비워놓기
            {
                Instantiate(Barrel, Middle.position, Quaternion.identity);
                Instantiate(Barrel, Left.position, Quaternion.identity);
            }
            //한번했으몀ㄴ 잠깐 멈추고싶다..이함수만...// n설정!?이게 최선인가,,ㅠ
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if(coll.tag == "Barrel") //Barrel과 부딪히면
        {
            Debug.Log("충돌 감지");
            life--; //생명 하나 줄어듦
            Debug.Log(life);
            Destroy(coll.gameObject); //충돌한 배럴 제거
        }
    }
}
