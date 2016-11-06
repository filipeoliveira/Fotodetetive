using UnityEngine;
using System.Collections;

public class Frame : MonoBehaviour {

	public int indice;
	public int score;

	void OnMouseDown(){
		transform.gameObject.GetComponent<Selectable> ().Select ();

		transform.parent.GetComponent<RelationManager> ().UpdateSelecionados();

		if (transform.gameObject.GetComponent<Selectable> ().isSelected) {
			transform.parent.GetComponent<RelationManager> ().AddOnSelecionados (this.transform.gameObject);
		}
	}
}
