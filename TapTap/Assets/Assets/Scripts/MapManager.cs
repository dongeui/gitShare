using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject[] maps = null; //원본 게임오브젝트 주소값

    private float interval = 0;

    private void Update()
    {
        interval += Time.deltaTime;

        //6.6초에 한번씩 그라운드 생성
        if (interval > 6.6f)
        {
            int index = Random.Range(0, 3); // 0 - 2 (정수일 경우)

            //Instantiate 생성(복제) 함수 (Instance)
            //생성된 게임오브젝트 주소값 = 생성 (복사기)
            GameObject obj = Instantiate(maps[index]);
            obj.transform.position = new Vector2(8, -2.2f);
            // print("Call!");

            interval = 0;
        }
    }
}