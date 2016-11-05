using UnityEngine;
using System.Collections;

public class Testemunhas : MonoBehaviour{
	
	public int indice;

	void OnMouseDown(){
		Debug.Log ("Oi");
		transform.gameObject.GetComponent<Selectable> ().Select ();

		transform.parent.GetComponent<RelationManager> ().UpdateSelecionados();

		if (transform.gameObject.GetComponent<Selectable> ().isSelected) {
			transform.parent.GetComponent<RelationManager> ().AddOnSelecionados (this.transform.gameObject);
		}
	}

}
