using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public Text txt;
	private Vector3 InitPos;
	private Vector3 CurPos;
	public GameObject Chart;

    // Start is called before the first frame update
    void Start()
    {
		txt = GetComponent<Text>();
		Chart.GetComponent<Transform>();
		InitPos = Chart.transform.position;
		CurPos = InitPos;
    }

    // Update is called once per frame
    void Update()
    {
		CurPos = Chart.transform.position;
		txt.text = "Position = " + (CurPos.z - InitPos.z)/ChartMovement.Unit + "Units";
    }
}
