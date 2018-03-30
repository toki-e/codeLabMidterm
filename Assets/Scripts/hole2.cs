using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class hole2 : MonoBehaviour {

    //public GameManager GameManager;
    public GameObject platformB;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll) {

        if (coll.gameObject == platformB) {

            GameManager.instance.Score++;
            Debug.Log("That's a point!");

        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject == platformB) {
            GameManager.instance.Score--;
            Debug.Log("goodbye point!");
        }
    }

}
