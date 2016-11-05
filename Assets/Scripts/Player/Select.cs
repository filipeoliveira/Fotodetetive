using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	public bool clique = false;
	public float ZoomSpeed = 4;
	public Vector3 tamanho;

	void Start(){
		tamanho = transform.localScale;
	}

	void Update(){
		GetInput ();
		PreparacaoClique ();
	}

	void OnTriggerStay2D(Collider2D other){
		int indice;
		clique = false;
		if (other.gameObject.tag == "Object" && Input.GetMouseButtonDown(0) && other.gameObject.GetComponent<Objeto>().descoberto) {
			indice = other.gameObject.GetComponent<Objeto> ().indice;
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		}
	}

	void PreparacaoClique(){
		if (Input.GetMouseButton(0) && transform.localScale.x > 0.9f*tamanho.x) {
			transform.localScale -= new Vector3(ZoomSpeed,ZoomSpeed,tamanho.x) * Time.deltaTime;
		} 
		if (!Input.GetMouseButton(0) && transform.localScale.x < tamanho.x) {
			transform.localScale += new Vector3(ZoomSpeed/2,ZoomSpeed/2,1) * Time.deltaTime;
		}

		if (!clique && transform.localScale.x > tamanho.x) {
			transform.localScale = new Vector3(tamanho.x,tamanho.x,tamanho.x);
		}

	}
	void GetInput(){
		if (!Input.GetMouseButton(0)) {
			clique = false;
		}
		if (Input.GetMouseButtonUp (0)) {
			clique = true;
		}
	}
}
