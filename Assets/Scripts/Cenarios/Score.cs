using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score = 0;

	public TextAsset textFile;
	public string[] textLines;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		initText();
	}

	public void addScore(int linha){
		score += int.Parse(textLines[linha])*50;
		Debug.Log (score);
	}

	void initText(){
		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}
	}
}
