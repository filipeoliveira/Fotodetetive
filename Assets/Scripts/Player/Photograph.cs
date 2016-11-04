using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	GameObject animacao;
	bool TirarFoto = false;//Carregando = false;

	void Update(){
		GetInput ();
	}

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && TirarFoto ) {
			TirarFoto = false;
			other.gameObject.GetComponent<Objeto> ().descoberto = true;
			ObjetoIndoParaGaleria (other);
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		}
	}

	void ObjetoIndoParaGaleria(Collider2D other){
		animacao = Instantiate (other.gameObject);
		animacao.GetComponent<SpriteRenderer> ().sprite = null;
		animacao.transform.localScale += new Vector3 (-0.5f, -0.5f, 0);
		animacao.gameObject.GetComponent<Objeto> ().countdown = true;
		other.gameObject.GetComponent<FadeObjectInOut> ().FadeIn ();
		animacao.gameObject.GetComponent<FadeObjectInOut> ().FadeIn (4f);
	}

	void GetInput(){
		if (Input.GetMouseButtonUp(0)) {
			TirarFoto = false;
		}
		if (Input.GetMouseButtonDown (0)) {
			TirarFoto = true;
		}
	}
}
