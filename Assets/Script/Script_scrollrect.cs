using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_scrollrect : ScrollRect 
{

    protected float mRadius = 0f;
    protected override void Start()
    {
        base.Start();

        mRadius = (transform as RectTransform).sizeDelta.x * 0.5f;


    }


    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);


        var contentPosition = this.content.anchoredPosition;
        if (contentPosition.magnitude > mRadius)
        {
            contentPosition = contentPosition.normalized * mRadius;
            SetContentAnchoredPosition(contentPosition);
        }

    }
}
