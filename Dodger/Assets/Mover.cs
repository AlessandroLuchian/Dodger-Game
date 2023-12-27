using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0.01f;
    [SerializeField] float zValue = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(xValue,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(-xValue,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(0,0,zValue);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0,0,-zValue);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
            transform.Translate(-xValue/2,0,zValue/2);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)){
            transform.Translate(-xValue/2,0,-zValue/2);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)){
            transform.Translate(xValue/2,0,-zValue/2);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)){
            transform.Translate(xValue/2,0,zValue/2);
        }
    }
}
