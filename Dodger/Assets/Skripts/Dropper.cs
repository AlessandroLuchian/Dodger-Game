using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float dropTime = 5f;
    private MeshRenderer fallingObjectMesh;
    private Rigidbody fallingObjectRigid;
    private void Start() {
        fallingObjectMesh = GetComponent<MeshRenderer>();
        fallingObjectMesh.enabled = false;
        fallingObjectRigid = GetComponent<Rigidbody>();
    }

    private void Update() {
        Debug.Log(" " +Time.time);
        checkToDropObject();
        
    }

    void checkToDropObject(){
        if(Time.time>dropTime){
            fallingObjectRigid.useGravity=true;
            fallingObjectMesh.enabled=true;
        }
    }
}
