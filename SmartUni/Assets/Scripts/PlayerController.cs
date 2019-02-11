using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public NavMeshAgent agent;

    public Dropdown dropdown;
    Vector3 xV;
    Transform destination;


    List<string> places = new List<string>() { "Select", "Building A", "Building B", "Building C", "Building D", "Building E", "Building F", "Building G", "Building H" };

    public LineRenderer line;
    


    void Start()
    {
        dropdown.AddOptions(places);

    }

    /*  mouse click position
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition.ToString());
        }
    }*/
    
    void Update()
    {
        
        var path = agent.path;
        if (path != null && path.corners.Length > 1)
        {
            line.positionCount = path.corners.Length;
            for (int i = 0; i < path.corners.Length; i++)
            {
                line.SetPosition(i, path.corners[i]);
            }
        }
    }
    
    public void StartPoint(int index)
    {
        
        destination = agent.transform;


        if (index == 1) { destination.position = new Vector3(-1092, 8, 1640); }
        if (index == 2) { destination.position = new Vector3(-810, 8, 1330); }
        if (index == 3) { destination.position = new Vector3(-1096, 8, 927); }
        if (index == 4) { destination.position = new Vector3(-1545, 8, 1726); }
        if (index == 5) { destination.position = new Vector3(-971, 8, 969); }
        if (index == 6) { destination.position = new Vector3(-807, 8, 1910); }
        if (index == 7) { destination.position = new Vector3(-1799, 8, 1290); }
        if (index == 8) { destination.position = new Vector3(-2413, 8, 1412); }

        agent.Warp(destination.position);
        
    }

    public void Nav (int index) {


        //Navigation animation (player movement)
        var path = agent.path;

        if (index == 1) { xV.Set(-1092, 8, 1640); }
        if (index == 2) { xV.Set(-810, 8, 1330); }
        if (index == 3) { xV.Set(-1096, 8, 927); }
        if (index == 4) { xV.Set(-1545, 8, 1726); }
        if (index == 5) { xV.Set(-971, 8, 969); }
        if (index == 6) { xV.Set(-807, 8, 1910); }
        if (index == 7) { xV.Set(-1799, 8, 1290); }
        if (index == 8) { xV.Set(-2413, 8, 1412); }

        agent.speed = 0;
        agent.SetDestination(xV);

        //DrawNavMeshPath.path = agent.path.corners;


        /*
            line = this.gameObject.AddComponent<LineRenderer>();
            line.material = new Material(Shader.Find("Sprites/Default")) { color = Color.green };
            line.startWidth = 2f;
            line.endWidth = 2f;
            //line.widthCurve = 20;
            line.startColor = Color.blue;
            line.endColor = Color.green;
            */


        //line.positionCount = (path.corners.Length);
        /*
        for (int i = 0; i < path.corners.Length; i++)
        {
            Debug.Log("for loop");
            line.SetPosition(i, path.corners[i]);
        }*/

    }

    public void Move()
    {
        agent.speed = 15;
    }




}