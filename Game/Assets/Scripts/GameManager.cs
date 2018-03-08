using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool isGameOver;
    public bool isFalling;

    public static int movesMade = 0;
    public Text moves;
    public Text timeLeft;
    public static float time = 99;
    public static int lvl = 2;

	// Use this for initialization
	void Start () {
        isFalling = false;
        isGameOver = false;
        moves.text = movesMade.ToString() + " moves made";

    }
	
	// Update is called once per frame
	void Update () {
        TimeTick();
	}

    public void UpMoveCounter ()
    {
        movesMade++;
        moves.text = movesMade.ToString() + " moves made";

    }

    void TimeTick()
    {
        time -= Time.deltaTime;
        timeLeft.text = time.ToString("f2");
    }

    public void LoadNextLevel()
    {
        lvl++;
        SceneManager.LoadScene("Lvl "+lvl, LoadSceneMode.Single);
        
    }

    public void WaitThenLoad()
    {
        Invoke("LoadNextLevel", 2.0f);
    }
}
