# 델리게이트

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
