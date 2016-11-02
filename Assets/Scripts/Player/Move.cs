using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public float speed;
	void Start(){
		Cursor.visible = false;
	}
	void Update () {
		Moving ();
	}

	void Moving(){
		transform.position += new Vector3 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"),0)*speed;
	}
}
