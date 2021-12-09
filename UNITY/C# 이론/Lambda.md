# Lambda(람다)

델리게이트 등에 매서드처럼 넘겨줄 수 있는 식

## 예시

```C#
public Func<string, int> a;

void Start(){
    a = (name) => name.Length;

    int cnt = a("EunJi");
}
```

# 간단한 콜백 시스템
```C#
public class Main : MonoBeviour
{
    //5초 뒤에 입력한 로그가 그대로 찍히는 결과
    void Start()
    {
        StartCoroutine(Test(() => {
            Debug.Log("델리게이트 실행!");
        }
        )); 
    }

    void Test(Action OnComplete = null)
    {
        yield return new WaitForSeconds(5.0f);

        if(onComplete != null)
            OnComplete();
    }
}
```