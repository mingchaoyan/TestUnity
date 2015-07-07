using UnityEngine;
using System.Collections;

public class RunTest : MonoBehaviour
{
	public Transform targetObject = null;

	// Use this for initialization
	void Start ()
	{
		if (targetObject != null)
			GetComponent<NavMeshAgent> ().destination = targetObject.position;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
