using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteOnClick : MonoBehaviour
{
    GameObject ball;

    void Start()
    {
        ball = GameObject.Find("boll");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(ball != null)
            {
                Destroy(ball);
            }
        }
    }
}
