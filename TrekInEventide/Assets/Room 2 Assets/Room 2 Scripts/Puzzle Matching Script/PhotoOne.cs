using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoOne : MonoBehaviour
{
   
    public GameObject object1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo1"))
        {
            object1.SetActive(true);
            Debug.Log("Photo one is triggered");
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo1"))
        {
            object1.SetActive(false);
            Debug.Log("Photo one has left the case");
        }
        
    }

}
