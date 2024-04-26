using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoThree : MonoBehaviour
{
   
    public GameObject object3;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo3"))
        {
            object3.SetActive(true);
            
        }
        
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Photo3"))
        {
            object3.SetActive(false);
            
        }
        
    }

}
