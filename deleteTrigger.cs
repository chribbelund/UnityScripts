using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteTrigger : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool destroySelf = false;

    void OnTriggerEnter2D()
    {
        if (destroySelf)
        {
            Destroy(this.gameObject);
        }
        Destroy(rb.gameObject);
    }

}
