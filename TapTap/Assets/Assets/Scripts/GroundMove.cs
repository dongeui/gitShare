using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    private void Update()
    {
        //Translate(x, y, z)
        //초당 1.2 이동
        transform.Translate(-1.2f * Time.deltaTime, 0, 0);
    }
}