using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	GameObject animacao;

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && Input.GetMouseButtonDown(0)) {
			animacao = Instantiate (other.gameObject);
			animacao.GetComponent<SpriteRenderer> ().sprite = null;
			animacao.transform.localScale += new Vector3 (-0.5f, -0.5f, 0);
			animacao.gameObject.GetComponent<Objeto> ().countdown = true;
			other.gameObject.GetComponent<FadeObjectInOut> ().FadeIn ();
			animacao.gameObject.GetComponent<FadeObjectInOut> ().FadeIn (4f);
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		}
	}
}
