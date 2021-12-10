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

 # 모노 싱글톤
 매 클래스 마다 _instance ~~로 싱글톤 코드를 매번 작성해야한다는 단점이 있다.
 모노 싱글톤은 이를 극복시켜 준다.
 추상 클래스를 이용해서 싱글톤을 상속한다.

```C#
//모노 싱글톤 생성
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T _instance;
    public static T Instance;
    {
        get
        {
            if(_instance == null)
                Debug.Log(typeof(T).ToString() + " is Null" );
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this as T;
    }
}

//모노 싱글톤 사용

public class Player : MonoSingleton<Player>
{
   public override void Init()
   {
       base.Init();
   }
}

//이전 싱글톤 사용과 같이 사용할 수 있다.
```