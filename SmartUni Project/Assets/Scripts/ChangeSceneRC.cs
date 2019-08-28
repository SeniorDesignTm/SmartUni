using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneRC : MonoBehaviour {

    void Start()
    {
        Screen.fullScreen = false;
    }

    public void mainmenu()
    {
        SceneManager.LoadScene ("MainMenu");
    }

    public void arcamera()
    {
        SceneManager.LoadScene ("ARCamera");
    }

    public void Campus()
    {
        SceneManager.LoadScene("Campus");
    }

    public void QRCam()
    {
        SceneManager.LoadScene("QRCam");
    }
}
