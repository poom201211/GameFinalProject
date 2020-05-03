using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour
{
    public KeyCode pressDown;
    public KeyCode pressUp;
    public KeyCode pressRight;
    public KeyCode pressLeft;

    float speed = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(pressDown)){
            transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKey(pressUp)){
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(pressLeft)){
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetKey(pressRight)){
            transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        
    }
}
