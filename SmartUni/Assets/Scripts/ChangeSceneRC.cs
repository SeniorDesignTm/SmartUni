using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneRC : MonoBehaviour {

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
}
