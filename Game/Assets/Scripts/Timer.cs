using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeRemaining = 99;
    public Text timerText;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timeTick();
	}

    public void timeTick ()
    {
        timeRemaining -= Time.deltaTime;
        timerText.text = timeRemaining.ToString("f2");
    }
}
