# 게임 첫 화면 만들기

## 스타트 버튼이 있는 화면을 만들어 보았다.

1. new Scene 만들기

2. 하이러라키 뷰에 UI -> Canvas 추가

3. Canvas 안에 UI -> Button 추가

4. Main Camera에 스크립트 추가

~~~c#
using UnityEngine.SceneManagement; //SceneManager 사용위해 추가

public class StartGameButton : MonoBehaviour

{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Button()
    {
      
            Invoke("startgame", .3f); // Invoke("실행함수", 지연시간)
        
    }
    private void startgame()
    {
        SceneManager.LoadScene("SampleScene"); //다음으로 SampleScene 불러옴
    }
}
~~~

5. Button Inspector를 보면 On Click()이 있는데 하단 + 를 누르고 그에 맞는 스크립트 함수와 Object을(여기서는 Main Camera) 넣어준다.

<img width="277" alt="onclilck" src="https://user-images.githubusercontent.com/28985207/52647579-556e4c80-2f28-11e9-8e34-b783c1743ec8.PNG">


6. File -> Build Setting 에서 씬들을 순서대로! 넣어준다.

7. 맨처음 씬부터 시작하면 실행된다.