using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerManager : MonoBehaviour {

	public GameObject[] Markers;
	public int unit;
	public int numberOfMarkers;
	public GameObject Marker; 
	public Transform template;
	public Transform Player;
	public Canvas markerNumber;
	// Use this for initialization
	void Start () {
		Marker.GetComponent<Canvas> ();

		Markers = new GameObject[numberOfMarkers];
		for (int i = 0; i < numberOfMarkers; i++) {
			GameObject go = Instantiate(Marker, new Vector3((float)template.position.x, 0.25f, Player.position.z + i*unit), Quaternion.identity) as GameObject;
			go.transform.localScale =new Vector3(0.1f,1f,0.1f);
			Markers[i] = go;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
