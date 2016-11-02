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

	void Start () {

		if(textFile != null){
			textLines = (textFile.text.Split ('\n'));
		}

	}

	void Update () {
		theText.text = textLines [currentLine];
	}
}
