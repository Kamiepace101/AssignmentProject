using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSquare : MonoBehaviour
{
    [SerializeField]
    private float force = 1000f;
    void Update () 
    {
        if (transform.position.y >= -8.5)
    {
        transform.Translate(0f, -0.25f, 0f);
    }
    }
}