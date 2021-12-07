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



