using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text textMI;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine = 0;
	public bool ativado = false;

	private double tempoDiminuindo = 0;
	public int tempoLimiteTexto = 5;

	void Start () {
		initText ();
	}

	void Update () {
		Debug.Log (currentLine);
		TextBoxActive ();
		currentLine = SumirTexto (currentLine);
		textMI.text = textLines [currentLine];
	}

	int SumirTexto(int line){
		if (line != 0) {
			tempoDiminuindo += Time.deltaTime;
			ativado = true;
		}
		if (tempoDiminuindo >= tempoLimiteTexto && line !=0) {
			line = 0;
			ativado = false;
			tempoDiminuindo = 0;
		}
		return line;
	}

	void TextBoxActive(){
		if (ativado) {
			transform.GetChild (0).gameObject.SetActive(true);
		} else {
			transform.GetChild (0).gameObject.SetActive(false);
		}
	}

	void initText(){
		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}
	}

	public void newTxt(bool ehDoMenuInvestigativo, int indice, bool Testemunha){
		int PulaLinha = 0;

		if (Testemunha && ehDoMenuInvestigativo) {
			currentLine = 101 + indice;
		}
		else if (ehDoMenuInvestigativo && !Testemunha) {
			currentLine = indice;
		} else {
			currentLine = (indice-1)*indice;
		}
	
	}
		
}
