# Enums

## 선언
```C#
public enum 이름{
    종류1,
    종류2,
    종류3
    , ... 등등
}

public 이름 변수이름;
```

## 사용 에시
```C#
switch(State)){
    case MoveState.Forward:
     ~~; break;
     case MoveState.Back:
     ~~; break;
     case MoveState.Stop:
     ~~; break;
     //...
}

```