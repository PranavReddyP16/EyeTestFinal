using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
	public GameObject Base;
	public GameObject HaloPrefab;

	private Vector3 BasePosition;

    // Start is called before the first frame update
    void Start()
    {
		Base.GetComponent<Transform>();
		BasePosition = Base.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	void OnCollisionEnter(Collision collision)
	{
		ChartMovement.Jump = 1;

		GameObject item = GameObject.FindWithTag("Respawn");
		while(item != null)
		{
			Destroy(item);
			item = GameObject.FindWithTag("Respawn");
		}

		GameObject halo = Instantiate(HaloPrefab) as GameObject;
		halo.transform.position = BasePosition;
	}
}
