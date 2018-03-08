using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPad : MonoBehaviour {

    public RollBox3 player;
    public GameManager gameManager;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (player.isStanding)
        {
            Debug.Log("Win!");
            gameManager.isGameOver = true;
        }
    }
}
