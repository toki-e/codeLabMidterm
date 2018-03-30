using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour {

    public bool canEnd = false;
    public GameObject player;
    public GameObject endScenePrefab;

    public KeyCode activateKey = KeyCode.Space;

    

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Score == 3)
        {
            canEnd = true;

            if (canEnd == true)
            {
                Instantiate(endScenePrefab, player.transform.position, transform.rotation);
                //rb.constraints = RigidbodyConstraints2D.FreezeAll;
                PlayerScript.canMove = false;

                if (Input.GetKey(activateKey))
                {
                    SceneManager.LoadScene(0);
                    PlayerScript.canMove = true;
                    canEnd = false;
                    GameManager.instance.Score = 0;
                    //Debug.Log(Score);
                }

            }
        }

    }
}
