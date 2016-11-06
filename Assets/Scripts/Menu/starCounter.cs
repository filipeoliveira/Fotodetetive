using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class starCounter : MonoBehaviour {

	public GameObject textManager, text1, text2, text3, text4;
	public int score;
	GameObject text, scorem;

	// Use this for initialization
	void Start () {
		scorem = GameObject.FindGameObjectWithTag ("ScoreCounter");
		score = scorem.GetComponent<Score> ().score;
		getStars ();
	}
	
	public void getStars(){
		if (score >= 2000) {
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
			text3.SetActive(true);
		} else if (score >= 1500) {
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 1);
			text2.SetActive(true);
		} else if (score >= 1000) {
//    		textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 1);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 2);
			text1.SetActive(true);
		} else {
			text4.SetActive(true);
		}
	}
}
