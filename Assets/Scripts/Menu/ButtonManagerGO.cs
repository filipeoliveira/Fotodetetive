using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManagerGO : MonoBehaviour {

	public void Restart(){
		SceneManager.LoadScene ("SelecaoCaso");
	}
}
