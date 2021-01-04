using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody rb;
    public float pushPower = 8.0F;
   

    void Start() {
        rb = GetComponent<Rigidbody>();// an object creat and show in inspector help to control the players
    }

    void Update()
    {
      

    }
   private void OnTriggerEnter(Collider other)
    {
        rb = GetComponent<Rigidbody>();// an object creat and show in inspector help to control the player
        if (other.gameObject.CompareTag("Robot") && Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30.0f);//ki
        }
        if (other.gameObject.tag == "Goall")
        {

            transform.position = GameObject.Find("BallPosition").transform.position;//ball going back to the original position
                                                                                    // Debug.Log("Gooooooooal!!!");
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;//ball stay on the ground


        }


    }

    
/*
      


    /*    void Update() {  //work  too fasttttttttttttttttttttttttt

         if (Input.GetKey(KeyCode.UpArrow) )
         {
             this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30.0f);//kick
         }

     }*/


    /*
public void OnTriggerEnter(Collider other)
{
   if ((Input.GetKey(KeyCode.UpArrow)) && (other.gameObject.tag == "Robot"))
   {
       other.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30.0f);//kick
   }
   if (other.gameObject.tag == "Goall")
   {

       transform.position = GameObject.Find("BallPosition").transform.position;//ball going back to the original position
                                                                               // Debug.Log("Gooooooooal!!!");
       this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;//ball stay on the ground


   }

}
*/

    /* void OnControllerColliderHit(ControllerColliderHit hit)
    {
       Rigidbody body = hit.collider.attachedRigidbody;

       // no rigidbody
       if (body == null || body.isKinematic)
           return;

       // We dont want to push objects below us
       if (hit.moveDirection.y < -0.3f)
           return;

       // Calculate push direction from move direction,
       // we only push objects to the sides never up and down
       Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

       // If you know how fast your character is trying to move,
       // then you can also multiply the push velocity by that.

       // Apply the push
       body.velocity = pushDir * pushPower;*/
    // }











    /*
        public float speed = 10;
        private Rigidbody r;//??
        float force;
        void Start()
        {
            force = 10;

            r = GetComponent<Rigidbody>();//??
        }

        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.name == "Robot")
            {
                transform.position += Vector3.forward * force * Time.deltaTime;
            }
        }



        public void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Goall")
            {

                transform.position = GameObject.Find("BallPosition").transform.position;//ball going back to the original position
                                                                                        // Debug.Log("Gooooooooal!!!");
                this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;//ball stay on the ground


            }
        }


   
    void FixedUpdate()
        {

                 transform.position += Vector3.forward * force * Time.deltaTime;
                float movementHorizontal = Input.GetAxis("Horizontal");
                float movementVertical = Input.GetAxis("Vertical");
                Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);
                r.AddForce(movement * speed);




        }

     */















}
