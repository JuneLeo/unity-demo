using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_slider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>().onValueChanged.AddListener(delegate (float progress)
        {
            Debug.LogFormat("当前进度为：{0}", progress);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
