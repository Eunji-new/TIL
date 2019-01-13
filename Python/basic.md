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

## 구구단함수를 만들어봤다..(연습문제)

>> def gugudan():

    for i in range(2,10):

        for j in range(1,10):

            print('%d * %d = %d' % (i,j,i*j))

        i = i+1

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

## 문자열, 목록(list)

### 문자열

x = 'apple'

x[0] 은 'a'

x[:3] 은 'app'

x[1:3] 은 'pp'

x[0]= 'p'로 바꿀 수 없음
(list는 가능)

### 목록(list)

list = [1,2,3,6]

list.append(5)

->list는 [1,2,3,6,5] 가 됨

sort ->순서대로 정렬

list.sort()

list = [1,2,3,5,6]

del list[2]

list = [1,2,5,6]

list[0] = 0

list = [0,2,5,6]

### 목록안에 목록도 가능하다.

orders = ['potato', ['pizza', 'Coke', 'salad'], 'hamburger']

 orders[1]
['pizza', 'Coke', 'salad']

orders[1][2] 'salad'

## 문자열을 list로 만들기

ch = []

word = 'word'

for i in word

    ch.append(i)
print(ch)

=>ch = ['w', 'o', 'r', 'd']가 된다.









    