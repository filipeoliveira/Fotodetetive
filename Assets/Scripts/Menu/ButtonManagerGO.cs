using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManagerGO : MonoBehaviour {

	GameObject scoreCounter;

	public void Restart(){
		scoreCounter = GameObject.FindGameObjectWithTag ("ScoreCounter");
		scoreCounter.GetComponent<Score> ().score = 0;
		SceneManager.LoadScene ("SelecaoCaso");
	}
}
