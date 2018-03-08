using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool isGameOver;
    public bool isFalling;
    public static bool showResults = false;

    public static int movesMade = 0;
    public Text moves;
    public Text timeLeft;
    public static float time = 99;
    public static int lvl = 1;
    int numberOfLevels = 3;
    bool resultsShown = false;


	// Use this for initialization
	void Start () {
        isFalling = false;
        isGameOver = false;
        moves.text = movesMade.ToString() + " moves made";
        
        
    }
	
	// Update is called once per frame
	void Update () {

        if (!showResults)
        {
            if (time > 0)
            {
                TimeTick();
            }
            if (time <= 0.001)
            {
                showResults = true;
                SceneManager.LoadScene("Results", LoadSceneMode.Single);
            }

        }

        if (!resultsShown)
        {
            resultsShown = true;
            ShowResultsText();       
        }
       
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
        isGameOver = false;

        if (lvl <= numberOfLevels)
        {
            SceneManager.LoadScene("Lvl " + lvl, LoadSceneMode.Single);
        }
        else
        {
            showResults = true;
            SceneManager.LoadScene("Results", LoadSceneMode.Single);
        }
        
        
    }

    public void WaitThenLoad()
    {
        Invoke("LoadNextLevel", 2.0f);
    }

    void ShowResultsText ()
    {
        timeLeft.text = "Time Left: "+time.ToString("f2");
        moves.text = "# of Moves Made: " + movesMade.ToString();
    }
}
