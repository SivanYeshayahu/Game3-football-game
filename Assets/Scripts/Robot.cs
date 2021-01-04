using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{


    public Transform aimTarget; // the target where we aim to land the ball
    float speed;
    Rigidbody rb;
    float f ;
    // Start is called before the first frame update
    // Start is called before the first frame update


    float force; // ball impact force

    bool hitting; // boolean to know if we are hitting the ball or not 

    public Transform ball; // the ball 
   

    Vector3 aimTargetInitialPosition; // initial position of the aiming gameObject which is the center of the opposite court

    
    GameObject robot;
    void Start()
    {
        f = 100;
        robot = GetComponent<GameObject>();
        speed = 10f; //player speed 
        rb = GetComponent<Rigidbody>();// an object creat and show in inspector help to control the player
        
       
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
        if (Input.GetKey(KeyCode.LeftArrow) )//player going left
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }

        /*
        if (this.gameObject.CompareTag("Ball") && Input.GetKey(KeyCode.Space))
        {
            //this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30.0f);//kick
        }
        */




    }


    /*

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Ball")
        {
            Debug.Log("We hit a object");
            hit.rigidbody.AddForce(transform.forward * f);
        }
    }
    */


}
