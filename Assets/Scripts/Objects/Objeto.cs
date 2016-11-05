using UnityEngine;
using System.Collections;

public class Objeto : MonoBehaviour {

	public int indice;
	public bool countdown = false;
	float timeLeft = 3.0f;
	public Sprite ani;
	public bool descoberto = false;
	public float ZoomSpeed = 4;
	public Vector3 tamanho;
	private bool clique;

	void Start(){
		tamanho = transform.localScale;
	}

	void Update(){
		if (Input.GetMouseButtonUp(0)) {
			clique = false;
		}

		if (countdown) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				transform.position = Vector3.MoveTowards (transform.position, GameObject.FindGameObjectWithTag ("Investigar").transform.position, 0.3f);
				if (transform.position != GameObject.FindGameObjectWithTag ("Investigar").transform.position) {
					gameObject.GetComponent<SpriteRenderer> ().sprite = ani;
					transform.localScale += new Vector3 (-0.02f, -0.02f, 0);
				}
				else
					gameObject.GetComponent<FadeObjectInOut> ().FadeOut (0.3f);
			}
		}
	}

	void OnMouseDown(){
		if (descoberto) {
			GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine = indice;
		} 
		clique = true;
	}

	void PreparacaoClique(){
		if (clique && transform.localScale.x > 0.9f*tamanho.x) {
			transform.localScale -= new Vector3(ZoomSpeed,ZoomSpeed,tamanho.x) * Time.deltaTime;
		} 
		if (!clique && transform.localScale.x < tamanho.x) {
			transform.localScale += new Vector3(ZoomSpeed/2,ZoomSpeed/2,1) * Time.deltaTime;
		}

		if (!clique && transform.localScale.x > tamanho.x) {
			transform.localScale = new Vector3(tamanho.x,tamanho.x,tamanho.x);
		}

	}
}
