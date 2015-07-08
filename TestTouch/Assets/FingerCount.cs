using UnityEngine;
using System.Collections;

public class FingerCount : MonoBehaviour
{
	public int fingerCount;

	// Update is called once per frame
	void Update ()
	{
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled) {
				fingerCount ++;
			}
			if (fingerCount > 0) {
				print ("User has " + fingerCount + "finger(s) touching the screen");
			}
		}
	}

	void OnGUI ()
	{
		GUILayout.Label (fingerCount + "");
	}
}
