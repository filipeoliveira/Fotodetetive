using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Text theText;//telaNormal
	public Text textMI;//menuInvestigacao

	public TextAsset textFile, textFile2;
	public string[] textLines, textLines2;

	public int currentLine, currentLine2;
	public bool ativado1 = false;

	private double tempoDiminuindo = 0;
	public int tempoLimiteTexto = 5;

	void Start () {
		initText ();
	}

	void Update () {
		


		TextBoxActive ();

		theText.text = textLines [currentLine];
		textMI.text = textLines2 [currentLine2];

		currentLine = SumirTexto (currentLine);
		currentLine2 = SumirTexto (currentLine2);
	}

	int SumirTexto(int line){
		if (line != 0) {
			tempoDiminuindo += Time.deltaTime;
			ativado1 = true;
		}
		if (tempoDiminuindo >= tempoLimiteTexto && line !=0) {
			line = 0;
			ativado1 = false;
			tempoDiminuindo = 0;
		}
		return line;
	}

	void TextBoxActive(){
		if (ativado1) {
			transform.GetChild (0).gameObject.SetActive(true);
		} else {
			transform.GetChild (0).gameObject.SetActive(false);
		}
	}

	void initText(){
		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}
		if(textFile2 != null){
			textLines2 = (textFile2.text.Split ('\n'));
		}
	}

	public void newTxt(bool ehDoMenuInvestigativo, int indice){
		if (ehDoMenuInvestigativo) {
			currentLine = 0;
			currentLine2 = indice;
		} else {
			currentLine = indice;
			currentLine2 = 0;
		}
	
	}
		
}
