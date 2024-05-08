using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour
{
    [Header("Camera Animation")]
    public Animator camAnim;
    
    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            camAnim.SetTrigger("Right");
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            camAnim.SetTrigger("Left");
        }
    }

    
}
