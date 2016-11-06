using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class starCounter : MonoBehaviour {

	public GameObject textManager;
	public int score;
	GameObject text, scorem;

	// Use this for initialization
	void Start () {
		scorem = GameObject.FindGameObjectWithTag ("ScoreCounter");
		//score = scorem.GetComponent<Score> ().score;
		score = 1001;
	}
	
	public void getStars(){
		if (score <= 1000) {
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
			text = GameObject.FindGameObjectWithTag("Text1");
		} else if (score <= 2000) {
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 1);
			text = GameObject.FindGameObjectWithTag("Text2");
		} else {
//    		textManager.GetComponent<TextBoxManager>().newTxt(false, 0);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 1);
//			textManager.GetComponent<TextBoxManager>().newTxt(false, 2);
			text = GameObject.FindGameObjectWithTag("Text3");
		}
		text.GetComponent<Text> ().enabled = true;
	}
}
