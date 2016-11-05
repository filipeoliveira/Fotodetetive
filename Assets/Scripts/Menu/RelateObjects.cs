﻿using UnityEngine;
using System.Collections;

public class RelateObjects : MonoBehaviour {

	public GameObject[] vetorSelecionados = new GameObject[2];

	void Update(){
		StillSelected();

		switch (CanRelateTo ()) {
		case "frame":
			GameObject.Find ("Canvas").transform.FindChild ("Relacionar").gameObject.SetActive (true);
			break;
		case "none":
			GameObject.Find ("Canvas").transform.FindChild ("Relacionar").gameObject.SetActive (false);
			break;
		}
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

	public string CanRelateTo(){
		if (vetorSelecionados [0] == null || vetorSelecionados [1] == null) {
			return "none";
		}
		if (vetorSelecionados.Length == 2) {
			if (vetorSelecionados [0].CompareTag ("Testemunha") || vetorSelecionados [1].CompareTag ("Testemunha")) {
				return "testemunha";
			} else {
				return "frame";
			}
		} else {
			return "none";
		}
	}
		
}
