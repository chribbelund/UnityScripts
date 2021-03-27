using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform playerBall;
    public float cameraDistance = 30.0f;
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerBall.position.x, playerBall.position.y, transform.position.z);
    }
}
