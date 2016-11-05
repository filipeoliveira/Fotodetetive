using UnityEngine;
using System.Collections;

public class Frame : MonoBehaviour {

	public int indice;
	public bool isSelected;

	public void Select(){
		isSelected = !isSelected;
	}

	void OnTriggerStay2D(Collider2D other){
		
		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("fudeu");
			Select ();
			if (isSelected) {
				transform.parent.gameObject.GetComponent<RelateObjects> ().AddToSelectList (this.transform.gameObject);

			}
		}
	}
}
