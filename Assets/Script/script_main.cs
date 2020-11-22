using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Script_04_12 script = Resources.Load<Script_04_12>("New Script_04_12");
        Debug.LogFormat("name:{0} id:{1}", script.playerInfos[0].name, script.playerInfos[0].id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
