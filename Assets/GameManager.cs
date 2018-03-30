using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null; //make game manager static

    public GameObject bgTilePrefab;
    public GameObject goodTilePrefab;
    public GameObject moveTilePrefab;
    public GameObject holePrefab;
    public GameObject endScenePrefab;
    public GameObject player;
    Rigidbody2D rb;

    public KeyCode activateKey = KeyCode.Space;

    public int Score = 0; //make this static

    public float tileWidth = 2f;
	public float tileHeight = 2f;

	public string levelFile = "level1.txt";

    public bool canEnd = false;


	// Use this for initialization
	void Start () {

        rb = player.GetComponent<Rigidbody2D>();

        //dont destroy the game manager!!
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    
        // Reading the file into string.
        string levelString = File.ReadAllText(Application.dataPath + Path.DirectorySeparatorChar + levelFile);

        // Splitting the string into lines.
        string[] levelLines = levelString.Split('\n');
        int width = 0;
        // Iterating over the lines.
        for (int row = 0; row < levelLines.Length; row++)
        {
            string currentLine = levelLines[row];
            width = currentLine.Length;
            // Iterating over all the chars in a line.
            for (int col = 0; col < currentLine.Length; col++)
            {
                char currentChar = currentLine[col];
                if (currentChar == 'x')
                {
                    //make bgTiles w no colliders
                    GameObject bgTile = Instantiate(bgTilePrefab);
                    bgTile.transform.parent = transform;
                    bgTile.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'o')
                {
                    // make pink tiles good to use for a path
                    GameObject goodTile = Instantiate(goodTilePrefab);
                    goodTile.transform.parent = transform;
                    goodTile.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0); //making tiles the right size
                }
                else if (currentChar == 'h') {

                    //making holes to cover w pink tiles
                    GameObject holeTile = Instantiate(holePrefab);
                    holeTile.transform.parent = transform;
                    holeTile.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
                else if (currentChar == 'm' ) {
                    //make platforms that need to fill the holes!
                    GameObject moveThisTile = Instantiate(moveTilePrefab);
                    moveThisTile.transform.parent = transform;
                    moveThisTile.transform.position = new Vector3(col * tileWidth, -row * tileHeight, 0);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

     

    }
}
