~~~c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsBullet : MonoBehaviour
{

    public AudioClip sndExp; // 폭파 사운드
    public Transform explode; // 불꽃 프리팹

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0) //포탄이 화면을 벗어날때
        {
            Destroy(gameObject); //포탄  제거
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        
        if (coll.tag == "Wall") //조건문을 걸어주지 않으면 충돌이 여러번 발생한다..왜인지는 모르겠다.
        {
            Instantiate(explode, transform.position, Quaternion.identity); //불꽃 프리팹 복제, Quaternion.identity는 프리팹의 회전이 필요없을 떄 사용
            Debug.Log("충돌 발생");
            Destroy(coll.gameObject); //벽 제거
            Destroy(gameObject); // 포탄 제거
            AudioSource.PlayClipAtPoint(sndExp, transform.position); //소리
        }
      
    }
}
