using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch3 : MonoBehaviour {

    //s3 makes platC move down

    Animator animA;
    Animator animC;

    public GameObject platformA;
    public GameObject platformC;
    public bool collidingWSwitch3;

    public KeyCode activateKey = KeyCode.Space;

	// Use this for initialization
	void Start () {

        animA = platformA.GetComponent<Animator>();
        animC = platformC.GetComponent<Animator>(); 
	}

    // Update is called once per frame
    void Update()
    {

        if (collidingWSwitch3 == true)
        {

            if (Input.GetKey(activateKey))
            {

                animA.SetBool("downA", true);
                animA.SetBool("upA", false);

                animC.SetBool("downC", true);
                animC.SetBool("upC", false);

            }


        }


    }

    private void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            collidingWSwitch3 = true;
            Debug.Log("touching s3");
        }

    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            collidingWSwitch3 = false;
            Debug.Log("not touching s3!");
        }
    }

}
