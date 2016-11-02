using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private Vector3 targetPos;

	void Start(){
		Cursor.visible = false;
		targetPos = transform.position;   
	}
	void Update () {
		Moving ();
	}

	void Moving(){
		float distance = transform.position.z - Camera.main.transform.position.z;
		targetPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		targetPos = Camera.main.ScreenToWorldPoint(targetPos);

		transform.position = Vector3.Lerp(transform.position, targetPos, 1);
	}
}
