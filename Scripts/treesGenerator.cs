using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treesGenerator : MonoBehaviour {

	public int defaultWidth;
	public int defaultLength;
	public int defaultDistance;

	public float minHeightScale = 0.8f;
	public float maxHeightScale = 1.2f;
	public GameObject[] trees;

	void Awake()
	{
		//Generate ();
	}

	public void Generate(int width, int length, int distance)
	{
		foreach (Transform child in transform) 
		{
			Destroy (child.gameObject);
		}
		if (trees.Length == 0)
			return;
		for (int i = 0; i < width; ++i) 
		{
			for (int j = 0; j < length; ++j) 
			{
				GameObject tree = Instantiate (trees [Random.Range (0, trees.Length)], 
					new Vector3 (distance * i+transform.position.x, transform.position.y, distance * j+transform.position.z),
					Quaternion.Euler (0, Random.Range (0, 360), 0), transform);
				tree.transform.localScale = new Vector3 (1, Random.Range (minHeightScale, maxHeightScale), 1); 
			}
		}
	}
	public void Generate()
	{
		Generate (defaultWidth, defaultLength, defaultDistance);
	}
}
