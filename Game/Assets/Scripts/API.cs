using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class API : MonoBehaviour {

    private const string URL = "http://techfair-data.comparably.com/culture/indeed.json";
    public JSONtoClass Data;
    public Text showData;
    
    
    void Start()
    {
        Request();
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
        Debug.Log(req.text);
        Debug.Log(Data);
        Debug.Log(Data.Company.url);
        Debug.Log(Data.company.name);
        Debug.Log(Data.company.location.city);
        Debug.Log(Data.company);
        Debug.Log(Data.culture);
        Debug.Log(Data.culture.happiness);
        Debug.Log(Data.culture.happiness.grade);
        Debug.Log(Data.culture.happiness.score);
               
    }

    public static JSONtoClass CreateFromJSON(string jsonString)
    {
        
        return JsonUtility.FromJson<JSONtoClass>(jsonString);

    }

    public void ShowResults()
    {
        showData.text = Data.culture.team.grade;
    }
}
