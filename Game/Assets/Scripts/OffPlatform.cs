using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OffPlatform : MonoBehaviour {

    public RollBox3 player;
    public GameManager gameManager;
    

    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Rigidbody>().useGravity = true;
        gameManager.isFalling = true;
        WaitThenRestart();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void WaitThenRestart()
    {
        Invoke("RestartLevel", 2.0f);
    }
}
