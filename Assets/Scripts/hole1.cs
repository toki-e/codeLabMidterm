using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole1 : MonoBehaviour {


    public GameObject platformA;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject == platformA) {
            GameManager.instance.Score++;
        }

    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject == platformA) {
            GameManager.instance.Score--;
        }
    }

}
