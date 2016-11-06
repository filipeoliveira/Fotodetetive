using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FrameMenuSelecao : MonoBehaviour {
	
	public string NomeCena;

	void OnMouseDown(){
		Debug.Log ("oi");
		SceneManager.LoadScene (NomeCena);
	}
}
