using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Script_gizmo : MonoBehaviour
{

    static Vector3[]  fourCorners= new Vector3[4];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        foreach(MaskableGraphic graphic in GameObject.FindObjectsOfType<MaskableGraphic>())
        {
            if (graphic.raycastTarget)
            {
                RectTransform rectTransform = graphic.transform as RectTransform;
                rectTransform.GetWorldCorners(fourCorners);
                Gizmos.color = Color.red;
               
                for(int i = 0; i < 4; i++)
                {
                    Gizmos.DrawLine(fourCorners[i], fourCorners[(i + 1)%4]);
                }
            }
        }
    }

}
