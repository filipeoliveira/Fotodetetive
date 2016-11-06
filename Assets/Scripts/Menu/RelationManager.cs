using UnityEngine;
using System.Collections;

public class RelationManager : MonoBehaviour {
	
	public GameObject[] Selecionados = new GameObject[2];
	public GameObject relacaoFrames;
	public GameObject relacaoFrameTestemunha;

	void Awake(){
		Selecionados [0] = Selecionados [1] = null;
	}

	void Update(){
		ShineSelecionados ();
		BotaoRelacionarFrames ();
		UpdateSelecionados ();
	}

	public void AddOnSelecionados(GameObject objeto){
		if (Selecionados [0] != null && Selecionados [1] != null) {
			Selecionados [0] = SetNull (Selecionados [0]);
			Selecionados [0] = objeto;
			Selecionados = EmOrdem (Selecionados);
		} else {
			for (int i = 0; i < 2; i++) {
				if (Selecionados [i] == null) {
					Selecionados [i] = objeto;
					break;
				}
			}
		}
		if (CheckDeDuasTestemunhas ()) {
			SetNullToAll ();
			Selecionados [0] = objeto;
		}
		return;
	}

	public void UpdateSelecionados(){
		for (int i = 0; i < 2; i++) {
			if (Selecionados[i] != null && !Selecionados [i].GetComponent<Selectable> ().isSelected) {
				Selecionados[i] = SetNull(Selecionados[i]);
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
		relacaoFrameTestemunha.SetActive (false);
		if (Selecionados [0] == null || Selecionados [1] == null) {
			return;
		}
		if (Selecionados [0].CompareTag ("Frame") && Selecionados [1].CompareTag ("Frame")) {
			relacaoFrames.SetActive (true);
		}
		if (Selecionados [0].CompareTag ("Testemunha") || Selecionados [1].CompareTag ("Testemunha")) {
			relacaoFrameTestemunha.SetActive (true);
		}
	}

	public void SetNullToAll(){
		for (int i = 0; i < 2; i++) {
			Selecionados [i] = SetNull (Selecionados [i]);
		}
	}
	GameObject SetNull(GameObject Selecionado){
		VoltaCor (Selecionado);
		Selecionado.GetComponent<Selectable> ().isSelected = false;
		Selecionado = null;
		return Selecionado;
	}

	public bool CheckDeDuasTestemunhas(){
		if (Selecionados [0] == null || Selecionados [1] == null) {
			return false;
		}
		if (Selecionados [0].CompareTag ("Testemunha") && Selecionados [1].CompareTag ("Testemunha")) {
			return true;

		}
		return false;

	}

}
