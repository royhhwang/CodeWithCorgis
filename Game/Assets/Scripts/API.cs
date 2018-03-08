using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class API : MonoBehaviour {

    private const string URL = "http://techfair-data.comparably.com/culture/yoga.json";
    public JSONtoClass Data;
    
    
    void Start()
    {
        Request();
    }

    public void Request()
    {
        Debug.Log("Requesting API...");
        WWW request = new WWW(URL);
        StartCoroutine(OnResponse(request));
    }

    private IEnumerator OnResponse(WWW req)
    {
        yield return req;
        Data = CreateFromJSON(req.text);
        Debug.Log(Data.company.name);
        
        
    }

    public static JSONtoClass CreateFromJSON(string jsonString)
    {
        Debug.Log("running");
        return JsonUtility.FromJson<JSONtoClass>(jsonString);

    }
}
