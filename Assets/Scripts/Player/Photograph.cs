using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	GameObject animacao;
	bool TirarFoto = false,Carregando = false;
	//public float zoomSpeed = 2;

	void Update(){
		if (Input.GetMouseButtonUp(0)) {
			TirarFoto = false;
			Carregando = false;
		}
		if (Input.GetMouseButtonDown (0)) {
			TirarFoto = true;
			Carregando = true;
		}
		//AnimacaoDiafragmaCamera ();

	}

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && TirarFoto ) {
			TirarFoto = false;
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

	/*
	void AnimacaoDiafragmaCamera(){
		if (Carregando && GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize >= 2f) {
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize -= zoomSpeed * Time.deltaTime;

		} else if (!Carregando) {
			if(GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize < 2.95f){
				GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize += zoomSpeed*4* Time.deltaTime;
			}
			if (GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize > 2.95f) {
				GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ().orthographicSize = 2.95f;
			}
		}
	}
	*/

}
