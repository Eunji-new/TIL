# Array

## 기본 사용
```C#
int[] array = new int[5]{1,2,3,4,5};
```
## 배열 동적할당

```C#
 array = (array?.Concat(new int[] { 추가하려는 것 }) ?? new int[] { 추가하려는 것 }).ToArray();
```

## Null 간단 체크

- ###  ?. 이란

    ex) a?.b --> a가 null이면 b 실행. null이 아니라면 그대로 a

- ### ?? 이란

    ex) a??b --> a가 null이면 b, a가 null이 아니라면 a 반환

- ### ??= 이란

    ex) a??=b --> a가 null 이라면 a에 b를 대입, null이 아니라면 그대로 a


<br>

 ## 배열 vs 리스트
 출처 : https://im-first-rate.tistory.com/124  [웃으면 1류다]

 ### 배열
 - 동적 할당 불가능
- 연속된 메모리 공간 -> 메모리 관리 용이
- 인덱스로 빠르게 접근 가능

### 리스트
- 포인터 사용, 다음 데이터의 주소값을 가지고 있다 --> 동적 할당 가능
- 메모리 측면에서는 비효율적(다음 데이터의 주소값을 가지고 있어야 하기 때문 - 불필요한 메모리 추가 사용)
- 인덱스가 없어 검색이 유용하지 않음


### 배열 vs 리스트 결론
 배열은 주로 정적인 경우에 사용한다.
 List가 동적일 때 유용

 ## 2차원 배열 

 ```C#
 int[,] array = new int[4, 2];

 array.GetLength(0); //row 길이
 array.GetLength(1); //column 길이
```



# List

## 선언
```C#
List <자료형 or 클래스> 이름 = new List<자료형 or 클래스>(); 
```
## 추가

```C#
list.Add();
```
## 삭제
```C#
list.Remove(값); //해당 값을 가지는 인덱스 요소 삭제
list.RemoveAt(인덱스); //해당 인덱스 요소 삭제 
list.RemoveRange(0,3); //0 인덱스 부터 3개 삭제
```

```C#
list.Clear();
```
