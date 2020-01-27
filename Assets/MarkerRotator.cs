using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public GameObject Marker;

	Vector3 V = new Vector3(10,10,10);

	// Update is called once per frame
	void Update () {
		Marker.transform.Rotate(V * Time.deltaTime);
	}
}