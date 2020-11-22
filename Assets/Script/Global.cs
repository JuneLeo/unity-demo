using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{

    public static Global instance;

    static Global(){
        GameObject gameObject = new GameObject("#Global#");
        DontDestroyOnLoad(gameObject);
        instance = gameObject.AddComponent<Global>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Global start");
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("Global update");
    }

    public void doSomeThings()
    {
        Debug.Log("Global doSomeThings");
    }
}
