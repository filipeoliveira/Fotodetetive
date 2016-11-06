using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile, textFile2;
	public string[] textLines, textLines2;

	public int currentLine, currentLine2;
	public bool ativado = false;

	private double tempoDiminuindo = 0;
	public int tempoLimiteTexto = 5;

	void Start () {

		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}
		if(textFile2 != null){
			textLines2 = (textFile2.text.Split ('\n'));
		}

	}

	void Update () {
		SumirTexto ();
		TextBoxActive ();

		theText.text = textLines [currentLine];
		theText.text = textLines2 [currentLine2];
	}

	void SumirTexto(){
		if (currentLine != 0) {
			tempoDiminuindo += Time.deltaTime;
			ativado = true;
		}
		if (tempoDiminuindo >= tempoLimiteTexto && currentLine !=0) {
			currentLine = 0;
			ativado = false;
			tempoDiminuindo = 0;
		}
	}

	void TextBoxActive(){
		if (ativado) {
			transform.GetChild (0).gameObject.SetActive(true);
		} else {
			transform.GetChild (0).gameObject.SetActive(false);
		}
	}
}
