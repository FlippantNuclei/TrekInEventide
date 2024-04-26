using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTwo : MonoBehaviour
{
   
    public GameObject object2;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo2"))
        {
            object2.SetActive(true);
            
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo2"))
        {
            object2.SetActive(false);
            
        }
        
    }

}
