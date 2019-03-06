# 프로젝트

앞으로 자동으로 가면서 방향키로 장애물 피하기...


## C# 스크립트 코드

 - 190114 ) 방향키를 너무 예민하게 잘받아서 극단적으로 이동함;;

 - 190115 ) GetKeyDown - 눌렀을때만....알던건데,,,,,,,,,,,,,이거떄문에 몇시간을,,,,,,,,,,,ㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷㄷㅂㄷㅂㄷㅂㄷㅂㄷㅂㄷ한심..

 - 190117 ) tranlate(상대좌표 - 매 프레임마다 값만큼 이동)와 position(절대좌표 - 순간이동)의 차이! + Debug.log();

 - 190206 ) Collsion관련 이벤트함수가 안떠서 한동안 다른거 하다가 왔더니 뜬다..;;무엇..부딪히면 사라지는 것까지 처리. 

 - 190207 ) 캡슐 position.x 가 언제부터인가 처음에 0으로 안뜬다..ㅜㅜㅜㅜㅜ

- 190210 ) 충돌이 아닌데 충돌이라해서 collider 변경 했는데도 그러길래 헤맸는데 prefab잘못본거였다ㅎㅎㅎ

- 190212 ) Object 크기와 속도 조절, 프레임과 moveSpeed 싱크가 안맞다.

- 190213 ) 게임 첫 화면을 만들었다. 

- 190225 ) 속도 밸런스 포기. 마지막 시간 상속만 제대로 받으면 될 것 같다.

- 190304 ) 상속받으면 데이터가 안넘어가나!?씬 넘어가면 데이터가 사라지는건가 : 이유 찾기...

- 190305 ) 씬넘어가도 데이터 유지 -> static 사용!!

- 190306 ) 배럴생성속도 조절(프레임 기준이아닌 캐릭터 위치기준으로 바꿔서 해결)


using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI; //UI사용위해서

using UnityEngine.SceneManagement; //SceneManager 사용위해


public class Main_Capsule_Controller :  MonoBehaviour
{

    public float moveSpeed = 6.0f;
    public float gap = 3f; //왼,중,오 간격
    private Transform character = null;
    public int life = 5; //생명 5개
    public Transform Barrel; // 배럴 프리팹

    public Transform Center;
    public Transform Middle;
    public Transform Middle2;
    public Transform Middle3;
    public Transform Middle4;
    public Transform Middle5;

    public Transform Left;
    public Transform Left2;
    public Transform Left3;
    public Transform Left4;
    public Transform Left5;
 
    public Transform Right;
    public Transform Right2;
    public Transform Right3;
    public Transform Right4;
    public Transform Right5;
  
    public int n = 0 ;
    public int count = 0;
    public int eight_z = 0; // 캐릭터가 8만큼씩 갔을때. 
    public Text timeText; //시간텍스트
    public Text lifeText;  // 생명텍스트
    float time = 0f;        //시간
    public static float endTime; // 버틴 시간



  /* 씬이 바뀌어도 이 게임오브젝트는 사라지지않게 함.
   void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    */
        // Start is called before the first frame update
        void Start()
    {
        character = this.gameObject.GetComponent<Transform>(); //메인 캡슐 캐릭터
        lifeText.text = "Life : ♥ ♥ ♥ ♥ ♥"; //처음 생명 5개
        start_barrel();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Create_Barrel();
        if ((int)character.position.z % 6 >= 1 && (int)character.position.z % 6 <= 5) //6~7 사이에 없을때
            eight_z = 0; // 8마다 한번씩 값 초기화 -> 8마다 배럴생성 가능하도록 만들어줌
        if (time >= 0)
        {
            time += Time.deltaTime; // 프레임 수 더해준다..((delta.Time으로 어느 컴이든 같게 기준
            timeText.text = "Time : " + time.ToString("F"); //time.Tostring("F")는 소숫점 많이 방출 방지
        }
      
    } //Update

    void start_barrel()
    {
        int empty = (int)Random.Range(1, 4); //가는길에 Barrel 비워둘 곳.
        int empty2 = (int)Random.Range(1, 4);
        int empty3 = (int)Random.Range(1, 4);
        int empty4 = (int)Random.Range(1, 4);

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


        if (empty2 == 1) //왼쪽 비워놓기
        {
            Instantiate(Barrel, Middle2.position, Quaternion.identity);
            Instantiate(Barrel, Right2.position, Quaternion.identity);
        }
        else if (empty2 == 2)// 가운데 비워놓기
        {
            Instantiate(Barrel, Left2.position, Quaternion.identity);
            Instantiate(Barrel, Right2.position, Quaternion.identity);
        }
        else //오른쪽 비워놓기
        {
            Instantiate(Barrel, Middle2.position, Quaternion.identity);
            Instantiate(Barrel, Left2.position, Quaternion.identity);
        }


        if (empty3 == 1) //왼쪽 비워놓기
        {
            Instantiate(Barrel, Middle3.position, Quaternion.identity);
            Instantiate(Barrel, Right3.position, Quaternion.identity);
        }
        else if (empty3 == 2)// 가운데 비워놓기
        {
            Instantiate(Barrel, Left3.position, Quaternion.identity);
            Instantiate(Barrel, Right3.position, Quaternion.identity);
        }
        else //오른쪽 비워놓기
        {
            Instantiate(Barrel, Middle3.position, Quaternion.identity);
            Instantiate(Barrel, Left3.position, Quaternion.identity);
        }


        if (empty4 == 1) //왼쪽 비워놓기
        {
            Instantiate(Barrel, Middle4.position, Quaternion.identity);
            Instantiate(Barrel, Right4.position, Quaternion.identity);
        }
        else if (empty4 == 2)// 가운데 비워놓기
        {
            Instantiate(Barrel, Left4.position, Quaternion.identity);
            Instantiate(Barrel, Right4.position, Quaternion.identity);
        }
        else //오른쪽 비워놓기
        {
            Instantiate(Barrel, Middle4.position, Quaternion.identity);
            Instantiate(Barrel, Left4.position, Quaternion.identity);
        }


    }

    void move() //캐릭터 기본 이동
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
          if(n%30 == 0)
        {
             moveSpeed += 0.005f; //속도 높
        } 
        
    }

    void Create_Barrel() //배럴 랜덤생성
    {
    
      //캐릭터가 ~만큼 전진했을때 생성되는걸로 맞추면 좋을것같당.
        if (((int)character.position.z) %6 == 0 && eight_z == 0) //8~9이
        {
                eight_z++;
                int empty5 = (int)Random.Range(1, 4); //가는길에 Barrel 비워둘 곳.
                int empty6 = (int)Random.Range(1, 4);
                int empty7 = (int)Random.Range(1, 4);
                int empty8 = (int)Random.Range(1, 4);
                int empty9 = (int)Random.Range(1, 4);
   
            if (empty5 == 1) //왼쪽 비워놓기
                {
                    Instantiate(Barrel, Middle5.position, Quaternion.identity);
                    Instantiate(Barrel, Right5.position, Quaternion.identity);
                }
                else if (empty5 == 2)// 가운데 비워놓기
                {
                    Instantiate(Barrel, Left5.position, Quaternion.identity);
                    Instantiate(Barrel, Right5.position, Quaternion.identity);
                }
                else //오른쪽 비워놓기
                {
                    Instantiate(Barrel, Middle5.position, Quaternion.identity);
                    Instantiate(Barrel, Left5.position, Quaternion.identity);
                }

        }
     

      
    }
    public void OnTriggerEnter(Collider coll)
    {
        
        if(coll.tag == "Barrel") //Barrel과 부딪히면
        {
            Debug.Log("충돌 감지");
            life--; //생명 하나 줄어듦
            Destroy(coll.gameObject); //충돌한 배럴 제거
            if (life == 4)
                lifeText.text = "Life : ♥ ♥ ♥ ♥";
            else if (life == 3)
                lifeText.text = "Life : ♥ ♥ ♥";
            else if (life == 2)
                lifeText.text = "Life : ♥ ♥";
            else if (life == 1)
                lifeText.text = "Life : ♥";
            else
            {
                lifeText.text = "Life : ";
                endTime = time;
                Button();
            }
        }
     
    }
    private void Button()
    {
        Invoke("gameover", .3f); // Invoke("실행함수", 지연시간)
    }
    public void gameover()
    {
        
        SceneManager.LoadScene("GameOver"); //다음으로 씬 GameOver 불러옴

        Debug.Log("게임오버 시간 :" + endTime);
        
   
    }

}
