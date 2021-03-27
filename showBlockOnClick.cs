using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showBlockOnClick : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool destroySelf = false;
    private bool triggerStay = false;

    void OnTriggerEnter2D()
    {
        triggerStay = true;
    }
    void OnTriggerExit2D()
    {
        triggerStay = false;
    }
    void Update()
    {
        if (triggerStay && Input.GetButtonDown("Fire1"))
        {
            if (destroySelf)
            {
                Destroy(this.gameObject);
            }
            rb.GetComponent<SpriteRenderer>().enabled = true;
            rb.GetComponent<BoxCollider2D>().enabled = true;

        }
    }
}
