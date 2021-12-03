# Static

* 일반 인스턴스 멤버: 객체 생성할 때마다 초기화
* 정적멤버 static : 초기화

```C#

public Employee(){
    Debug.Log("static 호출 다음으로!");
    Debug.Log("생성될 때마다 호출!");
    //생성할 때 마다 호출된다.
}

static Employee(){
    Debug.Log("static이 일반보다 먼저!");
    //가장 먼저 호출
    //여러번 생성돼도 한 번만 호출
}
```

# Utility Helper Class

- 일부 기능을 제공하여 기능을 보조
- 특정 클래스를 도와주기 위해 생성한 것
- but, 클래스의 주목적은 X

- Utility 클래스는 모든 매서드가 정적 매서드
- 일반적으로 helper 클래스의 모든 함수가 정적이지는 않으며, 여러개의 helper class의 인스턴스가 있을 수 있다.

** 유틸리티 클래스에 정적 함수를 만들어 놓고, 정작 사용할 때에는(helper 클래스) 정적으로 선언은 안해도 되고, 되도록 private 선언(외부에서 접근할 목적은 아니기 때문)

### 유틸리티 클래스 매서드 예시
- CreateObject()
- SetPositionToZero(GameObject obj)
- 숫자인가? 정수인가?
- 텍스트 박스 문자 선택
- 문자 분리 
- 등등...