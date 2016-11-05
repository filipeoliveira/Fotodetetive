using UnityEngine;
using System.Collections;

public class ShowItens : MonoBehaviour {

	void Update(){
		CheckIfWasDiscovered ();
	}

	public void CheckIfWasDiscovered(){
		for(int i = 0; i<transform.parent.GetComponent<ObjectManager>().quantidadeProvas; i++){
			if (transform.parent.GetComponent<ObjectManager> ().vetorObjetos [i] != null && transform.parent.GetComponent<ObjectManager> ().vetorObjetos [i].GetComponent<Objeto> ().descoberto) {
				transform.GetChild (i).gameObject.SetActive (true);
			} 

		}
	}
}
