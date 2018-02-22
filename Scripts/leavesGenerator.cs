using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leavesGenerator : MonoBehaviour {

	public GameObject[] leafBlocks;
	float minScale;


	Transform trans;
	Transform[] branches;
	public float minGeneralScale = 0.3f;
	public float maxGeneralScale = 1f;
	public float minLocalFlattening = 0.5f;
	public float maxLocalFlattening = 1.5f;

	void Awake () 
	{
		trans = GetComponent<Transform> ();
		branches = GetComponentsInChildren<Transform> ();
		int branchesLength = branches.Length;
		if (leafBlocks.Length == 0 || branchesLength == 0)
			return;

		GameObject blockToCut;
		for (int i=0; i<branchesLength; ++i)
		{
			if (branches[i].gameObject.GetInstanceID() != trans.gameObject.GetInstanceID()) 
			{
				blockToCut = Instantiate (leafBlocks[Random.Range(0, leafBlocks.Length-1)], new Vector3(branches[i].position.x, branches[i].position.y, branches[i].position.z)
					, Quaternion.Euler(0,0,0), branches[i]);
				float generalScale = Random.Range (minGeneralScale, maxGeneralScale);
				blockToCut.transform.localScale = new Vector3(
					generalScale * Random.Range (minLocalFlattening, maxLocalFlattening),
					generalScale * Random.Range (minLocalFlattening, maxLocalFlattening),
					generalScale * Random.Range (minLocalFlattening, maxLocalFlattening));
			}
		}
	}
}
