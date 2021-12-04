# 프로퍼티

```C#
public string Name{
    get{
        return name;
    }
    set{
        if(value == "eunji"){
            Debug.Log("my name is EunJi");
        }
        name = value;
    }
}

public float Speed{ get; private set; } //읽기 전용

public string major{ get; set; } //일반