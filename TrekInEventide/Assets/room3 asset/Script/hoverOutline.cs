using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hoverOutline : MonoBehaviour
{
    public GameObject theflowchart;

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
    private void OnMouseDown()
    {
        gameObject.GetComponent<Animator>().Play("bookMove");
        theflowchart.SetActive(true);
    }
}
