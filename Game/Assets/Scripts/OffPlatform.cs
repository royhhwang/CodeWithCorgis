using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffPlatform : MonoBehaviour {

    public RollBox3 player;
    public GameManager gameManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You fell off!");
        player.GetComponent<Rigidbody>().useGravity = true;
        gameManager.isGameOver = true;
        
    }
}
