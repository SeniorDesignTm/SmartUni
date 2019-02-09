using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationController : MonoBehaviour {

    List<string> places = new List<string>() { "Building D", "Building G", "Building H" };

    public Dropdown dropdown;
    public Text selectedPlace;

    public void Dropdown_indexChanged (int index)
    {
        selectedPlace.text = places[index];
    }

	void Start () {
        PopulateList();
	}
	
    void PopulateList()
    {
        dropdown.AddOptions(places);
    }
}
