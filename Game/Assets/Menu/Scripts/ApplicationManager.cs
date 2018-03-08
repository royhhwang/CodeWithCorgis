using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ApplicationManager : MonoBehaviour
{
    public PanelManager gameStart;
    public PanelManager getOutOfHere;
    Animator anim;

    public void GameStart()
    {
        anim = GetComponent<Animator>();

        Invoke("TransitionPlay", 1.0f);
        Invoke("DelayedGameStart", 4.0f);
        getOutOfHere.DestroyAll();
    }

    public void TransitionPlay()
    {
        anim.SetTrigger("GameOpen");
    }

    public void DelayedGameStart()
    {
        SceneManager.LoadScene("Lvl 1", LoadSceneMode.Single);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
