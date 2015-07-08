using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 0.01f;

	void Update ()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPostion = Input.GetTouch (0).deltaPosition;
			transform.Translate (touchDeltaPostion.x * speed, touchDeltaPostion.y * speed, 0);
		}
		print ("speed" + speed);
	}

	void OnGUI ()
	{
		GUILayout.Label ("speed: " + speed + "");
	}
}
