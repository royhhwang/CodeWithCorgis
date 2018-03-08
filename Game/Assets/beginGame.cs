using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginGame : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            Application.LoadLevel("Lvl 2");
        }
    }
}
