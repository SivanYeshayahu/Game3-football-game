using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRobot : MonoBehaviour
{
    public Transform target;  //  target is obj of class Transform  
    public float smoothSpeed = 5f; //camera speed
    public Vector3 offset; //offset is obj of class vector

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //Lerp -change values //calculation of Tracking the player
        transform.position = smoothedPosition;//Update the new position of camara
        transform.LookAt(target);//look at the player



    }
}
