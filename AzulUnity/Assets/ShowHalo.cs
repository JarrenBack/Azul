using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHalo : MonoBehaviour {

    public Behaviour halos;

    private void Start()
    {
        Debug.Log("Start triggered from ShowHalo");
        halos = (Behaviour)gameObject.GetComponent("Halo");
    }

    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter triggered");
        halos.enabled = true;
    }

    void OnMouseExit()
    {
        Debug.Log("OnMouseExit triggered");
        halos.enabled = false;
    }
}
