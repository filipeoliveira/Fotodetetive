using UnityEngine;
using System.Collections;

public class Testemunhas : MonoBehaviour{

	public int indice;
	public bool isSelected;
	public Color cor;

	void Start(){
		cor = transform.gameObject.GetComponent<SpriteRenderer> ().color;
	}

	void Update () {
		ShineOnSelection ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (Input.GetMouseButtonUp (0)) {
			AddList ();
		}
	}

	void AddList(){
		isSelected = !isSelected;
		if (isSelected) {
			transform.parent.gameObject.transform.parent.GetComponent<RelateObjects> ().AddToSelectList (this.transform.gameObject);
		}
	}

	void ShineOnSelection(){
		if (isSelected) {
			transform.gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.5f, 0.7f, 0.5f, 1f);
		} else {
			transform.gameObject.GetComponent<SpriteRenderer> ().color = cor;
		}
	}
}
