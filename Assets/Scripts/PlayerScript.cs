using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    //wasd control
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode leftKey = KeyCode.A;

    public float moveSpeed = 0.2f;

    public static bool canMove = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (canMove == true)
        {

            if (Input.GetKey(rightKey))
            {
                transform.Translate(moveSpeed, 0f, 0f);
                GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.GetKey(leftKey))
            {
                transform.Translate(-moveSpeed, 0f, 0f);
                GetComponent<SpriteRenderer>().flipX = true;
            }

            if (Input.GetKey(upKey))
            {
                transform.Translate(0f, moveSpeed, 0f);
            }

            if (Input.GetKey(downKey))
            {
                transform.Translate(0f, -moveSpeed, 0f);
            }
        }
	}
}
