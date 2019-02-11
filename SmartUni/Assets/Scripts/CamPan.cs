using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPan : MonoBehaviour {

    public float speed;
    public Camera cam;

	void Start () {
        
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        QualitySettings.antiAliasing = 0;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
	

	void Update () {
		
        if(Input.touchCount > 0 && Input.GetTouch(0) .phase == TouchPhase.Moved){
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            if (cam.transform.position.x < -600 && cam.transform.position.x > -2400)
            {
                transform.Translate(-touchDeltaPosition.x * speed, 0, 0);
            }
            else
            {
                if (cam.transform.position.x > -1500)
                {
                    cam.transform.position = new Vector3(transform.position.x - 50, 500, 1144);
                }
                if (cam.transform.position.x < -1500)
                {
                    cam.transform.position = new Vector3(transform.position.x + 50, 500, 1144);
                }
            }



        }
	}
}
