using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MovementController : MonoBehaviour
{
    Vector3 startPos;
    Vector3 startPosOfCube;
    Vector3 dist;

    void OnMouseDown()
    {
        startPosOfCube = transform.position;
        startPos = Camera.main.WorldToScreenPoint(transform.position);
        dist = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, startPosOfCube.y, startPos.z));
    }

    void OnMouseDrag()
    {
        Vector3 lastPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, startPos.z);
        transform.position = Camera.main.ScreenToWorldPoint(lastPos) + dist;
    }
}