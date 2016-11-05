using UnityEngine;
using System.Collections;

public class Photograph : MonoBehaviour {

	GameObject animacao, inv;
	public GameObject framemanager;
	bool TirarFoto = false;
	public float ZoomSpeed = 5; 
	Vector3 pos;

	void Start(){
	}

	void Update(){
		GetInput ();
		PreparacaoFoto ();
	}

	void OnTriggerStay2D(Collider2D other){
		int indice = 0;
		if (other.gameObject.tag == "Object" && TirarFoto ) {
			TirarFoto = false;
			other.gameObject.GetComponent<Objeto> ().descoberto = true;
			ObjetoIndoParaGaleria (other);
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			framemanager.GetComponent<FrameManager> ().MarkFrame (indice - 1);
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

	void PreparacaoFoto(){
		if (Input.GetMouseButton(0) && transform.localScale.x > 0.9f) {
			transform.localScale -= new Vector3(ZoomSpeed,ZoomSpeed,1) * Time.deltaTime;
		} 
		if (!Input.GetMouseButton(0) && transform.localScale.x < 1f) {
			transform.localScale += new Vector3(ZoomSpeed/2,ZoomSpeed/2,1) * Time.deltaTime;
		}
		
		if (!TirarFoto && transform.localScale.x > 1f) {
			transform.localScale = new Vector3(1,1,1);
		}

	}

	void GetInput(){
		if (!Input.GetMouseButton(0)) {
			TirarFoto = false;
		}
		if (Input.GetMouseButtonUp (0)) {
			TirarFoto = true;
		}
	}
}
