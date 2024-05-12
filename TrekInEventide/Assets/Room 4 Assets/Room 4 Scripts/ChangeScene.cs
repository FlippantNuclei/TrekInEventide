using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int NextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeToScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ChangeToScene()
    {
        yield return new WaitForSeconds(NextScene);
        
    }

    
}
