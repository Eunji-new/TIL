# LINQ 쿼리 

## Any
해당조건이 있다면 True, 아니면 False 반환
## Contains
해당 인자가 전체 목록에 있다면 True, 아니면 False 반환

## Distinct
중복이 제거된 리스트 반환
```C#
Array.Distinct();
```
## Where
조건에 맞는 값의 목록을 반환

```C#
//LINQ를 사용하여 69점을 초과하는 점수만 새로운 목록에 담는 프로그램 작성
public int[] quizGrades = {44,55,32,56,78,23,89,99,100};

void Start(){
    var gradePass = quizGrades.Where(qg => qg > 69);
    //내림차순 정렬
    var gradePassDesc = quizGrades.Where(qg => qg > 69).OrderByDescending;
    
    foreach(var grade in gradePass){
        Debug.Log(grade);
    }
}
```