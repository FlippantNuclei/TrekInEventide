using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoFour : MonoBehaviour
{
   
    public GameObject object4;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo4"))
        {
            object4.SetActive(true);
            
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo1"))
        {
            object4.SetActive(false);
            
        }
        
    }

}
