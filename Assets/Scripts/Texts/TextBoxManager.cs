using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public bool ativado = false;

	private double tempoDiminuindo = 0;
	public int tempoLimiteTexto = 5;

	void Start () {

		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}

	}

	void Update () {
		SumirTexto ();
		TextBoxActive ();

		theText.text = textLines [currentLine];
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
