using UnityEngine;
using System.Collections;

public class MenuInvestigativo : MonoBehaviour {

	public void MenuInvestigativoOnOff(){
		transform.FindChild ("telaNormal").gameObject.SetActive (!transform.FindChild ("telaNormal").gameObject.activeSelf);
		transform.FindChild ("menuInvestigativo").gameObject.SetActive (!transform.FindChild ("menuInvestigativo").gameObject.activeSelf);
		ResetaRelacao ();
	}

	public void ResetaRelacao(){
		transform.gameObject.GetComponentInChildren<RelateObjects> ().vetorSelecionados [0] = null;
		transform.gameObject.GetComponentInChildren<RelateObjects> ().vetorSelecionados [1] = null;
	}
}
