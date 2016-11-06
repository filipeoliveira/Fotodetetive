using UnityEngine;
using System.Collections;

public class MenuInvestigativo : MonoBehaviour {
	
	public bool ativado;

	void Update(){
		EstaAtivo ();
	}

	public void MenuInvestigativoOnOff(){
		transform.FindChild ("telaNormal").gameObject.SetActive (!transform.FindChild ("telaNormal").gameObject.activeSelf);
		transform.FindChild ("menuInvestigativo").gameObject.SetActive (!transform.FindChild ("menuInvestigativo").gameObject.activeSelf);

	}
	void EstaAtivo(){
		if (transform.FindChild ("telaNormal").gameObject.activeSelf) {
			ativado = false;
		} else {
			ativado = true;
		}
	}
}
