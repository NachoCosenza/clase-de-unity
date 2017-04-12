using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosa : MonoBehaviour {

	private Rigidbody rb;
	public float angle;
	public GameObject prefa;
	public Transform salida;
	public KeyCode rotacionI;
	public KeyCode rotacionD;
	public KeyCode tiro;



	public int valor = 1 ;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(rotacionD))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * angle);
		}

		if(Input.GetKey(rotacionI))
		{
			transform.Rotate (Vector3.up * Time.deltaTime * -angle);
		}
		//rb.AddRelativeForce (Vector3.forward);
		//rb.AddTorque (Vector3.up);
		//rb.AddRelativeTorque (Vector3.up);
		if(Input.GetKeyDown(tiro))
		{
			Instantiate (prefa,salida.position,salida.rotation);
		}
	}
}
