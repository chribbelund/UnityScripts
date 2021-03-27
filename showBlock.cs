using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBlock : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool destroySelf = false;

    void OnTriggerStay2D()
    {
        print("Staying");
        if (destroySelf)
        {
            Destroy(this.gameObject);
        }
        rb.GetComponent<SpriteRenderer>().enabled = true;
        rb.GetComponent<BoxCollider2D>().enabled = true;
    }
}
