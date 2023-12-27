using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0.01f,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(-0.01f,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(0,0,0.01f);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(0,0,-0.01f);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)){
            transform.Translate(-0.005f,0,0.005f);
        }
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)){
            transform.Translate(-0.005f,0,-0.005f);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)){
            transform.Translate(0.005f,0,-0.005f);
        }
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)){
            transform.Translate(0.005f,0,0.005f);
        }
    }
}
