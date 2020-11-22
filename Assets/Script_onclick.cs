using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class Script_onclick : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject image;
    public GameObject text;

    private void Awake()
    {
        UGUIEventListener.Get(image).onClick = onClick;
        UGUIEventListener.Get(text).onClick = onClick;
    }

    void onClick(GameObject gameObject)
    {
        if(gameObject == image)
        {
            Debug.Log("dian ji le image");
        } else if(gameObject == text)
        {
            Debug.Log("dian ji le text");

        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class UGUIEventListener : UnityEngine.EventSystems.EventTrigger
{

    public UnityAction<GameObject> onClick;
    
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        if (onClick != null)
        {
            onClick(gameObject);
        }
    }

    static public UGUIEventListener Get(GameObject gameObject)
    {
        UGUIEventListener listener = gameObject.GetComponent<UGUIEventListener>();
        if(listener == null)
        {
            listener = gameObject.AddComponent<UGUIEventListener>();
        }
        return listener;
    }


}
