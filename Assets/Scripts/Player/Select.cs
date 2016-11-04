using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		int indice;
		if (other.gameObject.tag == "Object" && Input.GetMouseButtonDown(0) && other.gameObject.GetComponent<Objeto>().descoberto) {
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		}
	}
}
