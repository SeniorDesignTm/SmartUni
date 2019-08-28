using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour {

    //public Transform Player;
    public Camera Cam1, Cam2;
    public bool camSwitch = false;

    public void changeCam()
    {
        camSwitch = !camSwitch;
        Cam1.gameObject.SetActive(camSwitch);
        Cam2.gameObject.SetActive(!camSwitch);
    }
}
