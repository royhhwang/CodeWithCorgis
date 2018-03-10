using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPad : MonoBehaviour {

    public RollBox3 player;
    public GameManager gameManager;
    public StageManager stageClear;

    public void Start()
    {
        stageClear.clear = false;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (player.isStanding)
        {
            gameManager.isGameOver = true;
            gameManager.WaitThenLoad();
            stageClear.clear = true;
        }
    }
}
