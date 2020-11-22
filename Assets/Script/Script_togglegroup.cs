using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_togglegroup : MonoBehaviour
{
    public Toggle[] toggles;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var toggle in toggles)
        {
            toggle.onValueChanged.AddListener(delegate (bool select) {
                Debug.LogFormat("toggle = {0}, select = {1}", toggle.name, select);
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
