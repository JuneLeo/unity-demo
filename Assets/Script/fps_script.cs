using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps_script : MonoBehaviour
{

    public float updateInterval = 0.5f;
    private float accum = 0;
    private int frames = 0;
    private float timeLeft = 0;
    private string stringFps;


    // Start is called before the first frame update
    void Start()
    {
        timeLeft = updateInterval;
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;
        if(timeLeft <= 0.0)
        {
            float fps = accum / frames;
            string format = System.String.Format("{0:F2} FPS", fps);
            stringFps = format;
            timeLeft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    private void OnGUI()
    {
        GUIStyle gUIStyle = GUIStyle.none;
        gUIStyle.fontSize = 30;
        gUIStyle.normal.textColor = Color.red;
        gUIStyle.alignment = TextAnchor.UpperLeft;
        Rect rt = new Rect(40, 0, 100, 100);
        GUI.Label(rt,stringFps,gUIStyle);
    }
}
