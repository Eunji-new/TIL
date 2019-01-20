# 문자열, 목록(list)

## 문자열

x = 'apple'

x[0] 은 'a'

x[:3] 은 'app'

x[1:3] 은 'pp'

x[0]= 'p'로 바꿀 수 없음
(list는 가능)

## 목록(list)

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

## 목록안에 목록도 가능하다.

orders = ['potato', ['pizza', 'Coke', 'salad'], 'hamburger']

 orders[1]
['pizza', 'Coke', 'salad']

orders[1][2] 'salad'

# 문자열을 list로 만들기

ch = []

word = 'word'

for i in word

    ch.append(i)
print(ch)

=>ch = ['w', 'o', 'r', 'd']가 된다.

# 튜플


t = (1,2,3)

t = 1,2,3 //괄호 없어도 됨

t = ('a','b','c')

t = 1,

t = () //empty일때는 괄호 무조건 필요


- 리스트와 달리 원소값 바로 못바꿈

## 튜플을 리스트로 , 리스트를 튜플로

t = (1,2,3)

a = list(t) // 튜플 -> 리스트

b = tuple(a) //리스트 -> 튜플

# dict

dic = {}

dic['apple'] = 'Red Fruit'

dic[1] = 1

dic['1'] = '1'

dic =  {1 : 1, '1' : '1', 'apple' : 'Red Fruit'} //값을 넣은 순서대로 저장되진 않음

dic.keys() = ['1', 1, 'apple'] //사전 dic의 key들을 새로운 리스트로

dic.values() = ['1', 1, 'Red Fruit'] //사전 dic의 값들을 새로운 리스트로

'apple' in dic => True

'strawberry' in dic => False







    