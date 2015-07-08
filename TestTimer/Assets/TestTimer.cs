using UnityEngine;
using System.Collections;

public class TestTimer : MonoBehaviour
{
	public float time = 2;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		time -= Time.deltaTime;
		if (time <= 0) {
			Debug.Log ("time's up!");
			time = 2;
		}
	}
}
