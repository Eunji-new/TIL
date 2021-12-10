# Singleton(싱글톤)

어디서나 접근할 수 있고, 고유한 하나의 객체만을 반환하는 클래스

```C#
private static GameManager _instance;
public static GameManager Instance
{
    get
    {
        if(_instance == null)
            Debug.LogError("The GameManager is NULL");
        return _instance;
    }
}

void Awake()
{
    _instance = this;
}
```

## 지연된 객체화(Lazy instantiate)
 싱글톤 객체가 없을 떄, null 에러가 아닌, 호출 시점에서 객체를 생성시킬 수 있다.

 ### 단점
 인스펙터에서 값을 초기화해야 할 경우는, 값을 넣을 수 없다.
```C#

 A.instance.A함수(); //A에서 선언된 변수를 A함수에서 바로 사용할 경우 에러
 ```