using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManagerCaso1 : MonoBehaviour {

	public Button yourButton;
	public GameObject relationManager;
	public GameObject[] frames = new GameObject[2];
	Vector3 pos1, pos2;
	public Transform line;
	public float lineWidth;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		frames[0] = relationManager.GetComponent<RelationManager>().Selecionados[0];
		frames[1] = relationManager.GetComponent<RelationManager>().Selecionados[1];

		// Essa e a parte que especifica a linha a ser usada na relacao. Faltou tambem um condicional para testar se a linha e diferente de "nada", ja que ser for a relacao nao existe
		int indice = 2;
		GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().currentLine2 = indice;

		pos1 = frames [0].transform.position;
		pos2 = frames [1].transform.position;
		Instantiate (line);
		line.gameObject.GetComponent<Line> ().start = frames[0].transform;
		line.gameObject.GetComponent<Line> ().target = frames[1].transform;
	}
	// Update is called once per frame
	void Update () { 
	}
}
