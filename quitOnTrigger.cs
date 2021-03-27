using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitOnTrigger : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Application.Quit();
    }

}
