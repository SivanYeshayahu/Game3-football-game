using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    float speed;
    Rigidbody rb;
    bool ball;
    GameObject robot;
    void Start()
    {
       
        robot = GetComponent<GameObject>();
        speed = 7f; //player speed 
        rb = GetComponent<Rigidbody>();// an object creat and show in inspector help to control the player
        ball = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {//the player keep moving
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))   //player going to 
        {
            transform.position -= Vector3.forward * speed * Time.deltaTime;//Current Location
        }
        if (Input.GetKey(KeyCode.RightArrow))   //player going to right
        {
            transform.position += Vector3.right * speed * Time.deltaTime;//Current Location
        }
        if (Input.GetKey(KeyCode.LeftArrow))//player going left
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;

        }
    }
    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ball" && Input.GetKey(KeyCode.UpArrow))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100.0f);
        }

    }


    

    
}
