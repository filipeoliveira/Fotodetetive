using UnityEngine;
using System.Collections;

public class Frame : MonoBehaviour {

	public int indice;

	void OnTriggerStay2D(Collider2D other){
		if (other.CompareTag ("Cursor") && Input.GetMouseButtonDown (0)) {
			transform.gameObject.GetComponent<Selectable> ().Select ();

			transform.parent.GetComponent<RelationManager> ().UpdateSelecionados();

			if (transform.gameObject.GetComponent<Selectable> ().isSelected) {
				transform.parent.GetComponent<RelationManager> ().AddOnSelecionados (this.transform.gameObject);
			}
		}
	}
}
