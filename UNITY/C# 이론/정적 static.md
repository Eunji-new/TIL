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