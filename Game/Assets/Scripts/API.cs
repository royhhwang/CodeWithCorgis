using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class API : MonoBehaviour
{

    private const string URL = "https://gist.githubusercontent.com/hjayyang94/73895232eea9cf1415509e21f6582381/raw/060d66d09be0c0d2a8967004f6eb9a589f607d55/indeed.json";
    public JSONtoClass Data;
    public Text showData;
    public GameManager gameManager;
    public Button resultsButton;
    Animator anim;
    int additiveScore;

    void Awake()
    {
        Request();
        Button btn = resultsButton.GetComponent<Button>();
        btn.onClick.AddListener(continueResults);
        anim = GetComponent<Animator>();
    }

    public void Request()
    {

        WWW request = new WWW(URL);
        StartCoroutine(OnResponse(request));
    }

    private IEnumerator OnResponse(WWW req)
    {
        yield return req;
        Data = CreateFromJSON(req.text);

        int companyScore = Int32.Parse((Data.culture.happiness.score.Substring(4, 1)));

        additiveScore = gameManager.yourScore - companyScore;


        if (additiveScore <= 1)
        {
            additiveScore = 1;
        }

        showData.text = "Compared to others, your are the top " + additiveScore.ToString() + "%! " +
            "\r\n Click here to continue...";
    }

    public static JSONtoClass CreateFromJSON(string jsonString)
    {

        return JsonUtility.FromJson<JSONtoClass>(jsonString);

    }

    public void continueResults()
    {
        showData.text = "Get ready to move to " + Data.company.location.city + " because you're a perfect fit for " + Data.company.name;
        Invoke("RestartGame", 5.0f);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Menu 3D", LoadSceneMode.Single);
    }
}
