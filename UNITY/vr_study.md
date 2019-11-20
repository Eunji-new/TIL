# 엘리베이터 구현
## 부드럽게 움직이기
191119 ) Lerp사용

191120) Vector3.Lerp(start.position, End.position, 0~1사이값)
3번째 매개변수 0이면 시작위치값 반환, 1이면 end 반환,0.5면 중간값반환.
  ~~~cpp
  this.transform.position = Vector3.Lerp(this.transform.position, a.position, fracJourney);
  ~~~
 대충 이렇게 쓰면 서서히 움직인다는데 반환값을 position으로 넣으면 순간이동아닌가??진짜 나는 모르게따...
 
 SmoothDamp를 사용해야할것같다.
  
