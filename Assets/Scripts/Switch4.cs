using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch4 : MonoBehaviour
{

    public bool collidingWSwitch4;
    public KeyCode activateKey = KeyCode.Space;

    public GameObject platformA;
    public GameObject platformC;

    Animator animA;
    Animator animC;

    // Use this for initialization
    void Start()
    {
        animA = platformA.GetComponent<Animator>();
        animC = platformC.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (collidingWSwitch4 == true)
        {
            if (Input.GetKey(activateKey)) {

                animA.SetBool("upA", true);
                animA.SetBool("downA", false);

                animC.SetBool("upC", true);
                animC.SetBool("upC", false);

            }


        }


    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            collidingWSwitch4 = true;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") {
            collidingWSwitch4 = false;
        }
    }

}
