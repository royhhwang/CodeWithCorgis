using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPad : MonoBehaviour {

    public RollBox3 player;


    private void OnTriggerEnter(Collider collider)
    {
        if (player.isStanding)
        {
            Debug.Log("Win!");
        }
    }
}
