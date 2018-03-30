using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Switch2 : MonoBehaviour
{
    //switch 2 moves platform A down
    //switch 2 makes platform B move down

    private KeyCode activateKey2 = KeyCode.Space;
    public GameObject platformA2;
    public GameObject platformB; //testing second platform with animator instead!
    Animator animA;
    Animator animB;
    

   // public bool movedDownA = false;
    public bool collidingWSwitch2;

    public float moveSpeed2 = 5f;
    private Vector3 endPos = new Vector3(0.73f, -0.79f, 0f);
    //private float currentPlatformPos = platformA2.transform.position.y; 

    // Use this for initialization
    void Start()
    {
        animA = platformA2.GetComponent<Animator>();
        animB = platformB.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collidingWSwitch2 == true)
        {
            if (Input.GetKey(activateKey2))
            {
                //platformA2.transform.Translate(new Vector3(0f, moveSpeed2, 0f)); //just move it back 
                // Debug.Log("pushed 2nd Switch");

                //platA anim bools
                animA.SetBool("downA", true);
                animA.SetBool("upA", false);

                //platB anim bools
                animB.SetBool("switchPressed", true);
                animB.SetBool("downSwitchPressed", false); // if you press this, PB should move down

            }
                // movedDownA = true;
            

        }

       /* if (platformA2.transform.position.y > -1 && platformA2.transform.position.y < -0.7)
        {
            platformA2.transform.Translate(new Vector3(0f, -moveSpeed2, 0f)); // moveSpeed2 = 0;
        }*/
    }

    void OnCollisionStay2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            collidingWSwitch2 = true;
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
            collidingWSwitch2 = false;
            Debug.Log("no longer touching switch 2");
        }
    }
}



