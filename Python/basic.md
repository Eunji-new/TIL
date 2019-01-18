## 새로운 것들

1. 반복문, 조건문 뒤에는 : 을 꼭 써줘야함

2. printf아니고 print임

3. 들여쓰기 필요한 부분은 꼭 해줘야함

4. i++같은게 안됨...?

# while 예제

num = 1
while num <= 100 :
    print(num)
    num = num + 1
# if 예제
a = 10
b= 10
if a > b :
    print("a")
elif a == b :
    print("a==b")
else :
    print("a < b")


# for 예제

list = [1,2,3,4]
for i in list:
    print('%d' % (i))

* range(1,4) --> 1, 2, 3

## lambda
 lambda x, y : x+y

 ## map

 map(함수, 리스트)
 리스트 각각 받아서 각각 실행시켜서 새로운 리스트 생성

 ## reduce

 reduce(함수, 순서형 자료)

차례대로 받아서 실행 ->결과는 하나

## filter
 
filter( 함수 , 리스트)

참인것들만 새로운 리스트에 넣어준다.

