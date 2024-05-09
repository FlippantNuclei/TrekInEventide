using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverBirdOutline : MonoBehaviour
{
    private void OnMouseEnter()
    {
        gameObject.GetComponent<Outline>().enabled = true;
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Outline>().enabled = false;
    }
}
