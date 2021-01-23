using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSquare : MonoBehaviour
{
    [SerializeField]
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Hit Deadzone");
    }
    void Update () 
    {
        if (transform.position.y >= -8.5)
    {
        transform.Translate(0f, -0.25f, 0f);
    }
    }
}