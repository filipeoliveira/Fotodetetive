using UnityEngine;
using System.Collections;

public class RelationManager : MonoBehaviour {
	
	public GameObject[] Selecionados = new GameObject[2];
	public GameObject relacaoFrames;
	//public GameObject relacaoFrameTestemunha;

	void Update(){
		ShineSelecionados ();
		BotaoRelacionarFrames ();
	}

	public void AddOnSelecionados(GameObject objeto){
		for (int i = 0; i < 2; i++) {
			if (Selecionados [i] == null) {
				Selecionados [i] = objeto;
				return;
			}
		}
		VoltaCor (Selecionados [0]);
		Selecionados [0] = objeto;
		Selecionados = EmOrdem (Selecionados);
		return;
	}

	public void UpdateSelecionados(){
		for (int i = 0; i < 2; i++) {
			if (Selecionados[i] != null && !Selecionados [i].GetComponent<Selectable> ().isSelected) {
				VoltaCor (Selecionados [i]);
				Selecionados [i] = null;
			}
		}
		return;
	}

	public void ShineSelecionados(){
		for (int i = 0; i < 2; i++) {
			if (Selecionados[i] != null){
				Selecionados [i].GetComponent<Selectable> ().ShineOnSelection ();
			}
		}
		return;
	}

	public void VoltaCor(GameObject objeto){
		objeto.GetComponent<SpriteRenderer> ().color = Color.white;
		return;
	}

	public GameObject[] EmOrdem(GameObject[] vetor){
		GameObject temp = vetor [0];
		vetor [0] = vetor [1];
		vetor [1] = temp;
		return vetor;
	}

	public void BotaoRelacionarFrames(){
		relacaoFrames.SetActive (false);
		if (Selecionados [0] == null || Selecionados [1] == null) {
			return;
		}
		if (Selecionados [0].CompareTag ("Frame") && Selecionados [1].CompareTag ("Frame")) {
			relacaoFrames.SetActive (true);
		}
	}



}
