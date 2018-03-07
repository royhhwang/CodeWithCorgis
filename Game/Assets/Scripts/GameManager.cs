using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public bool isGameOver;

    public int movesMade;
    public Text moves;
	// Use this for initialization
	void Start () {
        isGameOver = false;
        movesMade = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpMoveCounter ()
    {
        movesMade++;
        moves.text = movesMade.ToString() + " moves made";

    }
}
