using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FrameMenuSelecao : MonoBehaviour {
	
	public string NomeCena;

	void OnTriggerStay2D(Collider2D other){
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (NomeCena);
		}
	}
}
