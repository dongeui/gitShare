using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    //충돌시 호출되는 함수 (유니티가 호출)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy 게임오브젝트 또는 컴포넌트 삭제
        Destroy(collision.gameObject);

        //print("OnTriggerEnter2D");
    }
}