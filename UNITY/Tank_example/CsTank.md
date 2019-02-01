using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsTank : MonoBehaviour
{

    public GameObject turret; //포탑
    public GameObject gun; // 포신
    public Transform Bullet; //포탄 프리팹
    Transform spPoint; //스판 포인트(발사되는곳)
    

    int moveSpeed = 5; // 이동속도
    int rotSpeed = 200; //회전속도
    int power = 1800; //포탄의 발사 파워

    // Start is called before the first frame update
    void Start()
    {
        spPoint = transform.Find("Turret/Gun/Cannon/spPoint"); //주의! 경로를 정확하게 입력한다.
        turret = transform.Find("Turret").gameObject;
        gun = transform.Find("Turret/Cannon").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        float amtMove = moveSpeed * Time.smoothDeltaTime;
        float amtRot = rotSpeed * Time.smoothDeltaTime;

        float keyMove = Input.GetAxis("Vertical"); //-1 ~ 1을 리턴(W, 상 키 -> 0~1, S, 하 키 -> -1 ~ 1)
        float keyRot = Input.GetAxis("Horizontal");//-1 ~ 1을 리턴(D, 우 키 -> 0~1, A, 좌 키 -> -1 ~ 1)

        float keyTurret = Input.GetAxis("Turret");
        float keyGun = Input.GetAxis("Mouse ScrollWheel");

        transform.Translate(Vector3.forward * amtMove * keyMove); //이동
        transform.Rotate(Vector3.up * amtMove * keyRot); //회전

        turret.transform.Rotate(Vector3.up * amtMove * keyTurret);
        gun.transform.Rotate(Vector3.right * keyGun * 10);

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("키 눌림");
            FireBullet();
        }
    } // Update


    //포탄 발사
    void FireBullet()
    {   
        //프리팹 만들기
        Transform obj = Instantiate(Bullet, spPoint.position, spPoint.rotation) as Transform;
        // 발사
       
        obj.GetComponent<Rigidbody>().AddForce(spPoint.forward * power);

    }
}


