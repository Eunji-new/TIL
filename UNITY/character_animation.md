# 유니티 캐릭터 & 애니메이션

## Assets
- 프로젝트 안에서 사용되는 다양한 리소스들이 모여있는곳
- Images
- Audios
- Scripts
- Models
- Animations
- Prefabs
- 보통 위 요소들로 구성됨
## 캐릭터
Window의 Asset Store(Ctrl + 9)에서 다운로드, 임폴트
### - 프리팹
보통 하늘색 큐브모양

오브젝트

### - 머티리얼

### - 텍스쳐

## 애니메이션
Assets에 Animations 폴더 안에
Animator Controller를 생성해준다.

이미 다운받은 Asset 캐릭터의 Animation으로 동작들을 넣어준다. 

그리고 그 캐릭터의 inspector의 Animator의 controller에 만든 Animaition을 맞게 넣어준다 (이거 빼먹어서 동작이 안먹길래 잠깐 헤맸다.ㅠㅠ)

수평(h), 수직(v) 값 받아오기 // 코드 상에서도 추가해줘야함
-> animator의 Parameter에서 추가

코드에서 h, v값을 못받는다....

- 해결) 코드를 if문 안에 잘못 넣어버렸다고 한다..됴륵

그래도 캐릭터가 안 움직인다...

- 해결) has exit time(방향키 누르면 바로 될 수 있게 해줌) 체크 풀기!!!!

animator의 Blend tree --> 여러 변수들을 효율적으로 관리할 수 있게 해줌 //부딪히는 것 같은 물리적 효과 표현에 도움

rigidbody component
-> 중력 효과 풀어줌 : 왜??

-> apply root motion 풀어줌 ->그래야 스크립트 자체에서 캐릭터의 위치와 회전 제어 가능


### 충돌 감지
capsule collider component 추가해줌
(다른 물체들이 이 캡슐을 중신으로 충돌함)

* 애니메이션 관련 코드 첨부

using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class MainController : MonoBehaviour
{
    
    public Animator animator;
    public Rigidbody rigidbody;

    private float h; //수평
    private float v; //수직

    private float moveX, moveZ; //X(좌우), Z(앞뒤)축의 거리, Y는 공중
    private float speedZ = 80f; //앞이동속도: 옆보다 빠름
    private float speedH = 50f; //옆이동속도

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))//사용자가 Space키를 눌렀을때만 한해서,GetKey면 Space키를 누르고 있을떄 계속 점프
        {
            animator.Play("JUMP00", -1, 0);
            //두번쨰 인자는 레이어, 기본적인 레이어는 -1임
            //세번째 넣어서 시간차 없애줌
        }
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical"); //-1부터1까지 정보가 담기게 됨.

        animator.SetFloat("h", h); //실제 애니메이션에서 h와 v의 정보를 이용할수있게해줌
        animator.SetFloat("v", v);

        moveX = h * speedH * Time.deltaTime;
        //deltaTime : 어떤 컴퓨터든 같은 속도를 낼수있게 해줌
        moveZ = v * speedZ * Time.deltaTime; 

        if(moveZ <= 0) //뒤로 갈때
        {
            moveX = 0; //옆으로 못감
        }

        rigidbody.velocity = new Vector3(moveX, 0, moveZ);
         
    }
}
