using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;


public class First : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Logged firstttttttttttt");
        action("/23/off");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void action(string a)
    {
        Debug.Log("Inside Action");
        string url = @"https://mmhdowsn.p18.rt3.io" + a;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip;
        var html = "";
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            html = reader.ReadToEnd();
        }

        Debug.Log(html);

    }
}
