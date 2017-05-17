using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //null = 주소값
    public Rigidbody2D rig = null;

    private int starCount = 0;

    //구현 (유니티 최초 한번)
    //초기화
    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Star")
        {
            //starCount = starCount + 1;
            starCount++;
            print("starCount" + starCount);
            Destroy(collision.gameObject);
        }
    }

    //유니티 계속 호출 (1초에 60fps =>모바일 기준)
    //갱신
    private void Update()
    {
        bool result = Input.GetMouseButtonDown(0);

        if (result == true)
        {
            //Vector2.zero => x = 0 y = 0
            rig.velocity = Vector2.zero;
            rig.AddForce(new Vector2(0, 4), ForceMode2D.Impulse);

            // print("점프!!");
        }
    }
}