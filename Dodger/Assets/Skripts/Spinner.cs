using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.5f;
    // Update is called once per frame
    void Update()
    {
        float zValue = Time.deltaTime * moveSpeed;
        transform.Rotate(0,0,zValue);
    }
}
