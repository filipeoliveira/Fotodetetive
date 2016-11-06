using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {

	public bool isSelected = false;

	public void Select(){
		isSelected = !isSelected;
	}

	public void ShineOnSelection(){
		transform.gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.5f, 0.7f, 0.5f, 1f);
	}
}
