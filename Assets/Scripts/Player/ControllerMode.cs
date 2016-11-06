using UnityEngine;
using System.Collections;

public class ControllerMode : MonoBehaviour {
	
	private bool modoCamera = false;

	void Update () {
		Comando ();
		SeMenuInvestigacao ();
		MudaModo ();
	}

	void Comando(){
		if (Input.GetAxis ("Mouse ScrollWheel") != 0) {
			modoCamera = !modoCamera;
		}
	}

	void MudaModo(){
		if (modoCamera) {
			transform.GetChild (0).gameObject.SetActive(false);
			transform.GetChild (1).gameObject.SetActive(true);
		} else {
			transform.GetChild (1).gameObject.SetActive(false);
			transform.GetChild (0).gameObject.SetActive(true);
		}
	}
	void SeMenuInvestigacao(){
		if(GameObject.Find("Cenario").GetComponent<MenuInvestigativo>().ativado){
			modoCamera = false;
		}
	}
}
