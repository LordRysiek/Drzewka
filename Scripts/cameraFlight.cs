using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlight : MonoBehaviour {

	public float diagonalSpeed = 0.1f;
	public Transform target;

	Transform tran;
	float radius;

	void Awake()
	{
		tran = GetComponent<Transform> ();
		tran.LookAt (target);
	}
	void Update()
	{
		tran.LookAt (target);
		tran.Translate (diagonalSpeed * Time.deltaTime * Vector3.left);
	}
}
