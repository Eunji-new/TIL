# Trigger

GameObject간의 물리적연산을 하지않고 충돌을 감지할수있다.
두 GameObject가 서로 접촉했을 때 튕겨나가지 않고 그냥 통과한다.

1. void OnTriggerEnter(Collider col)

- 충돌이 시작되는 순간 호출

2. void OnTriggerEnter(Collider col)

- 충돌이 진행중일떄

3. void OnTriggerEnter(Collider col)

- 충돌이 끝날 때

# Collision

물리적 연산을 하며 충돌을 감지한다.
Rigidbody의 Kinermatic 속성이 꺼져있어야 충돌 발생 가능!

1. void OnCollisionEnter(Collider col)

- 충돌이 시작되는 순간 호출

2. void OnCollisionEnter(Collider col)

- 충돌이 진행중일떄

3. void OnCollisionEnter(Collider col)

- 충돌이 끝날 때


# 1. Static Collider

collider존재, rigidbody X

움직이지 않는 오브젝트에 사용

## 2. rigidbody Collider

collider와 rigidbody 둘 다 존재

물리적인 충돌과 힘에 반응.

## 3.Kinemaric  rigidbody Collider 

Kinematic 옵션이 활성화.

물리적 힘이나 충돌에 반응 X

이동시킬 수 있다.

## 4. Trigger

단단한 객체 X

물체를 단순히 통과시킴.




## 3. 
### 왜 내 유니티에서는 이 함수가 존재하지않는가....?