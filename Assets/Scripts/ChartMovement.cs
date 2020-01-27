using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartMovement : MonoBehaviour
{
	public static  int Unit = 0;
	public static int Jump = 1;
	public GameObject Chart;
	public int LowerLimit = 0;
	public int UpperLimit = 0;

	// Start is called before the first frame update
	void Start()
	{
		Chart.GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update()
	{
		if(OVRInput.Get(OVRInput.Button.Two) || OVRInput.Get(OVRInput.Button.Three))
		{
			if(LowerLimit<=Chart.transform.position.z && Chart.transform.position.z<=UpperLimit)
			{
				Chart.transform.Translate(Vector3.forward * Unit * Jump);
			}
		}

		if(OVRInput.Get(OVRInput.Button.One) || OVRInput.Get(OVRInput.Button.Four))
		{
			if(LowerLimit<=Chart.transform.position.z && Chart.transform.position.z<=UpperLimit)
			{
				Chart.transform.Translate(-Vector3.forward * Unit * Jump);
			}
		}
	}
}
