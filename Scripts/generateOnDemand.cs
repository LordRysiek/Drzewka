using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateOnDemand : MonoBehaviour {

	treesGenerator gen;

	void Awake()
	{
		gen = GetComponent<treesGenerator> ();
	}
	void Update()
	{
		if (Input.GetButton ("Jump")) 
		{
			gen.Generate ();
		}
	}
}
