using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonManagerHistoriaC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Prosseguir(){
		SceneManager.LoadScene ("gameOver");
	}
}
