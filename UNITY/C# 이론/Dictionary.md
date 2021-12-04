# Dictionary

```C#
public Dictionary<type1, type2> Dict = new Dictionary<type1, type2>();

Dict.Add(value1, value2); //딕셔너리 값 추가
```

## 딕셔너리 반복

```C#
//키-값 쌍 반복
foreach(KeyValuwPair<int, string> item in Dict){
    Debug.Log("Key : " + item.Key);
    Debug.Log("Value : " + item.Value);
}

//키 값만 반복
foreach(int key in Dict.Keys){
    Debug.Log("Key : " + key);
}

//값만 반복
foreach(string value in Dict.Values){
    Debug.Log("Value : " + value);
}
```