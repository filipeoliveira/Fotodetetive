using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {
	
	public int quantidadeProvas;
	public GameObject[] vetorObjetos;

	void Start () {
		quantidadeProvas = transform.FindChild ("telaNormal").childCount;
		vetorObjetos = new GameObject[quantidadeProvas];

		}
	void Update(){
		IsThisDiscovered ();
	}

	public void IsThisDiscovered(){
		for (int i = 0; i < quantidadeProvas; i++) {
			if (transform.FindChild ("telaNormal").GetChild (i).gameObject.GetComponent<Objeto> ().descoberto) {
				vetorObjetos [i] = transform.FindChild ("telaNormal").GetChild (i).gameObject;
			} else {
				vetorObjetos [i] = null;
			}
		}
	}

}
		

