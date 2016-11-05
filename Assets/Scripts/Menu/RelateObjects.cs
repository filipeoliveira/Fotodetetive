using UnityEngine;
using System.Collections;

public class RelateObjects : MonoBehaviour {

	public GameObject[] vetorSelecionados = new GameObject[2];

	void Update(){
		//Conserta casos errados:
		StillSelected();
		//isEqual();
	}

	public void AddToSelectList(GameObject frame){
		if (vetorSelecionados [0] == null) {
			vetorSelecionados [0] = frame;
		} else if (vetorSelecionados [1] == null) {
			vetorSelecionados[1] = frame;
		} else {
			vetorSelecionados [0] = frame;
		}
	}

	void StillSelected(){
		for (int i = 0; i< 2; i++) {
			if (vetorSelecionados[i] != null && !vetorSelecionados[i].GetComponent<Frame> ().isSelected) {
				vetorSelecionados[i] = null;
			}
		}
	}
	void isEqual(){
		if (vetorSelecionados[0] != null && vetorSelecionados [0] == vetorSelecionados [1]) {
			vetorSelecionados [1] = null;
		}
	}
}
