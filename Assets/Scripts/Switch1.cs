using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour {

    //switch 1 makes platformA move up
    //switch 1 should make platformB move down

    private KeyCode activateKey = KeyCode.Space;
    public GameObject platformA;
    public GameObject platformB;
   

   // public bool movedDownA = false; //dont use this
    public bool collidingWSwitch = false;

    Animator animA;
    Animator animB; 

    public float moveSpeed = 5f;

	// Use this for initialization
	void Start () {
        animA = platformA.GetComponent<Animator>();
        animB = platformB.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

       if (collidingWSwitch == true)
        {
            if (Input.GetKeyDown(activateKey)) /*&& platformA.transform.position.y > -3.2f && platformA.transform.position.y < -0.79)*/
            {
                // platformA.transform.Translate(new Vector3(0f, -moveSpeed, 0f));
                animA.SetBool("upA", true);
                animA.SetBool("downA", false);
               
                animB.SetBool("downSwitchPressed", true);
                animB.SetBool("switchPressed", false);
            }       
                
        }
	}

    void OnCollisionEnter2D(Collision2D coll) //why doesnt this work ugh collisions in unity amirite
    {
        
            if (coll.gameObject.tag == "Player")
            {
                Debug.Log("colliding w 1st switch");
                collidingWSwitch = true;

                if (Input.GetKey(activateKey))
                {
                    //platformA.transform.Translate(new Vector3(0f, -moveSpeed, 0f));
                    //movedDownA = true;
                    Debug.Log("recognized input");
                }
            }
            else {
                collidingWSwitch = false;
            }
        

        /*if (movedDownA == true) {
            if (coll.gameObject.tag == "Player") {
                platformA.transform.Translate(new Vector3(0f, moveSpeed, 0f));
                movedDownA = false;
            }
        }*/

    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            collidingWSwitch = false;
            Debug.Log("not touching switch 1");
        }
    }

}
