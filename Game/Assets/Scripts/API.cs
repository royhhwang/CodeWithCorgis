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
        showData.text = Data.company.name;   
               
    }

    public static JSONtoClass CreateFromJSON(string jsonString)
    {
        
        return JsonUtility.FromJson<JSONtoClass>(jsonString);

    }
}
