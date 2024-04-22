using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject flowchart1;
    // Start is called before the first frame update
    void Start()
    {
        flowchart1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (lb_Bird.triggerDia1 == true)
        {
            flowchart1.SetActive(true);
        }
    }
}
