# 델리게이트

- 여러 함수를 담을 수 있다.

## 선언
```C#
public delegate void ChangeColor(Color newColor);
public ChangeColor OnColorChange();

public delegate void OnComplete();
public OnComplete onComplete;

void Start(){
    OnColorChange = UpdateColor;
    OnColorChange(Color.green);
    //void UpdateColor(Color new Color)

    OnComplete = Task;
    OnCompelte();
    //void Task()
}
```
- 델리게이트를 선언한 뒤, 선언한 델리게이트를 객체로 생성한다.
- 선언한 델리데이트와 인자가 같은 매서드 대입 가능
- 델리게이트에 매서드를 저장하여 호출 가능

# 이벤트

버튼 클릭 같은 이벤트들을 굳이 받지 않고도 스크립트 상에서 이벤트 제어 가능하다.

## 선언
```C#
public class Main : MonoBehaviour
{

    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClick(){
        OnClick();
    }
}
```
## 사용
```C#
Main.OnClick += 함수이름;
Main.OnClick -= 함수이름;
```

Main 클래스의 ButtonClick()함수를 적당하게 사용하면, 이벤트가 여러 오브젝트들에 한번에 적용되게 할 수 있다.

# Action

델리게이트 선언과 생성을 동시에 한줄로 할 수 있다.

사용법은 델리게이트와 같다. <>안에 사용하고 싶은 인자를 넣어서 사용하면 된다.

### 선언
```C#
public static Action<int> action;
```

# 반환형 델리게이트
```C#
public delegate int A(string text);
A a;

public Func<string, int> _A;

//a와 A_는 완전히 같은 일을 함
a = B;
A_ = B;

int cnt_a = a("Merry Christmas");
int cnt_A =A("Happy New Year");


int B(string s){
    return s.Length;
}
```

