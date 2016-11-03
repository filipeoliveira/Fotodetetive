using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	private double tempoDiminuindo = 0;
	public int tempoLimiteTexto = 5;

	void Start () {

		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}

	}

	void Update () {
		SumirTexto ();
		theText.text = textLines [currentLine];
	}

	void SumirTexto(){
		if (currentLine != 0) {
			tempoDiminuindo += Time.deltaTime;
		}
		if (tempoDiminuindo >= tempoLimiteTexto && currentLine !=0) {
			currentLine = 0;
			tempoDiminuindo = 0;
		}
	}
}
