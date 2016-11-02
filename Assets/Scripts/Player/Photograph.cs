using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "Object" && Input.GetMouseButtonDown(0)) {
			other.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
