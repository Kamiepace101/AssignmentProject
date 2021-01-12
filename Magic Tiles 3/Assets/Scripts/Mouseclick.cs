using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseclick : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,3f);
    }

    // Update is called once per frame
    private void Update()
    {
        //use left mouse buttton to make the blue boxes vanish
        //we are going to use local variable
        //the button destroy represents the left mouse down button 
        //bool pressedDestroyButton = Input.GetMouseButtonDown();
        

        //if pressedDestroyButton is true which means we are pressing Left mouse button
        //make the boxes vanish
        //if the pressedDestroyButton = true
        // if(pressedDestroyButton)
        // {
        //     Debug.Log("You pressed the left mouse button");
        // }
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }


    private void OnMouseDown() 
    {
        Debug.Log("You clicked the tile");
        Destroy(gameObject);
    }
}

