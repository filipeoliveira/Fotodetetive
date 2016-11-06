using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ButtonManagerCaso1 : MonoBehaviour {

	public Button yourButton;
	public Button Testemunhas;

	public GameObject relationManager, counter;
	public GameObject[] frames = new GameObject[2];
	public GameObject[] testemunhas = new GameObject[2];
	Vector3 pos1, pos2;
	public Transform line;
	public float lineWidth;


	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

		Button btn2 = Testemunhas.GetComponent<Button> ();
		btn2.onClick.AddListener (TestemunhaTask);
	}

	void TaskOnClick(){
		frames[0] = relationManager.GetComponent<RelationManager>().Selecionados[0];
		frames[1] = relationManager.GetComponent<RelationManager>().Selecionados[1];

		/*pos1 = frames [0].transform.position;
		  pos2 = frames [1].transform.position;*/
		InstanciaLinha ();

	}
	void InstanciaLinha(){
		//Instancia como filha de menuInvestigtivo, logo, só aparecerá quando este menu estiver ativo ~~Pedro
		GameObject linha = Instantiate (line).gameObject;
		linha.transform.parent = GameObject.Find ("menuInvestigativo").transform;

		line.gameObject.GetComponent<Line> ().start = frames[0].transform;
		line.gameObject.GetComponent<Line> ().target = frames[1].transform;

		counter.GetComponent<Score> ().addScore (100);

		relationManager.GetComponent<RelationManager> ().SetNullToAll ();
	}
	void TestemunhaTask(){
		int indiceFinal = 0;

		testemunhas[0] = relationManager.GetComponent<RelationManager>().Selecionados[0];
		testemunhas[1] = relationManager.GetComponent<RelationManager>().Selecionados[1];

		indiceFinal = calculaIndice (testemunhas);

		GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().newTxt (true, indiceFinal,true);
	}

	int DetermineTestemunha(GameObject[] testemunhas){
		if (testemunhas [0].CompareTag ("Testemunha")) {
			return 0;
		} else {
			return 1;
		}
	}
	int calculaIndice(GameObject[] vetor){
		return (vetor [1 - DetermineTestemunha (vetor)].GetComponent<Frame> ().indice - 1) + 
			(vetor [DetermineTestemunha (vetor)].GetComponent<Testemunhas> ().indice - 1) * 10;
	}
}
