using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

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

		pos1 = frames [0].transform.position;
		pos2 = frames [1].transform.position;

		//Instancia como filha de menuInvestigtivo, logo, só aparecerá quando este menu estiver ativo ~~Pedro
		GameObject linha = Instantiate (line).gameObject;
		linha.transform.parent = GameObject.Find ("menuInvestigativo").transform;

		line.gameObject.GetComponent<Line> ().start = frames[0].transform;
		line.gameObject.GetComponent<Line> ().target = frames[1].transform;

		relationManager.GetComponent<RelationManager> ().SetNullToAll ();
	}
	// Update is called once per frame
	void Update () { 
	}
}
