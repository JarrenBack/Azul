﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag triggered");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag triggered");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag triggered");
    }



}
