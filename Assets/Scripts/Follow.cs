using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float speed = 2.0f;

    void Update()
    {
        //rotate enemy to look at player
        transform.LookAt(target);

        //Vector3.forward vs transform.forward
        //Vector3.forward represent world space forward direction, like north, west, east, south
        //transform.forward represent local space forward direction, like right, left, up, down
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
