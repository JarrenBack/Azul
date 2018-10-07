using UnityEngine;
using System.Collections;


public class DragScript : MonoBehaviour
{

    private Vector3 dragPosition;

    void OnMouseDrag()
    {
        dragPosition = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.z);
        dragPosition = Camera.main.ScreenToWorldPoint(dragPosition);
        dragPosition.y = 0.0f; // assuming 2D game
    }

    void Update()
    {
        transform.position = dragPosition;
    }
}