using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    int score=0;
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        movePlayer();
    }

    public void movePlayer(){
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
    private void OnCollisionEnter(Collision other){
        Debug.Log("Your score is " + ++score);
    }
}
