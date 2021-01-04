using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public float pushPower = 2.0F;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goall")
        {

            transform.position = GameObject.Find("BallPosition").transform.position;//ball going back to the original position
                                                                                    // Debug.Log("Gooooooooal!!!");
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;//ball stay on the ground


        }
    }

    }
