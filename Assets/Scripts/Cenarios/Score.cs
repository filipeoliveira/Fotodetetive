using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public int score = 0;

	public TextAsset textFile;
	public string[] textLines;
	public Slider display;
	public Button concluir;

	Color displayColor;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		initText();
	}

	public void addScore(int linha){
		score += int.Parse(textLines[linha])*50;
		display.value = score;
		if (score >= 2000) {
			displayColor = Color.green;
			concluir.gameObject.SetActive (true);
		} else if (score >= 1500) {
			displayColor = Color.yellow;
			concluir.gameObject.SetActive (true);
		} else if (score >= 1000) {
			displayColor = Color.red;
			concluir.gameObject.SetActive (true);
		} else {
			displayColor = Color.black;
			concluir.gameObject.SetActive (false);
		}
		ColorBlock cb = display.colors;
		cb.disabledColor = displayColor;
		cb.highlightedColor = displayColor;
		cb.normalColor = displayColor;
		cb.pressedColor = displayColor;
		display.colors = cb;
	}

	void initText(){
		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}
	}
	public bool existeLinha(int indice){
		if (int.Parse (textLines [indice]) == -1) {
			return false;
		}
		return true;
	}
}
