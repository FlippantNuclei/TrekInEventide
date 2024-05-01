using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCameraRoom2 : MonoBehaviour
{
    [Header("Camera")]
    public int CameraTime;

    public GameObject Camera;

    [Header("PlayerController")]
    public FPSController PlayerController;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGame());
        Cursor.visible = false;
    }

    public IEnumerator StartGame()
    {
        yield return new WaitForSeconds(CameraTime);
        Camera.SetActive(false);
        PlayerController.enabled = true;
    }

}
