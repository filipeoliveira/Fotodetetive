using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && Input.GetMouseButtonDown(0)) {
			other.gameObject.GetComponent<Objeto> ().countdown = true;
			other.gameObject.GetComponent<FadeObjectInOut> ().FadeIn ();
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		}
	}
}
