using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosa2 : MonoBehaviour {
	private Rigidbody rb;
	public float angle;
	public KeyCode RotacionAB;
	public KeyCode RotacionAR;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(RotacionAR))
		{
			transform.Rotate (Vector3.forward * Time.deltaTime * angle);
		}

		if(Input.GetKey(RotacionAB))
		{
			transform.Rotate (Vector3.forward * Time.deltaTime * -angle);
		}
		
	}
}
