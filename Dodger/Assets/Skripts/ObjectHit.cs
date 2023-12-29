using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System;
public class ObjectHit : MonoBehaviour{
    private void OnCollisionEnter(Collision other){
        System.Random random = new System.Random();
        GetComponent<MeshRenderer>().material.color = new Color((float)random.Next(2),(float)random.Next(2),(float)random.Next(2),(float)random.Next(2));
    }
}
