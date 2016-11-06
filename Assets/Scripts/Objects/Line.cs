using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

	public Transform start;
	public Transform target;
	public GameObject bm;

	public int indiceFinal;

	LineRenderer line;
	CapsuleCollider capsule;

	// Use this for initialization
	void Start () {



		line = gameObject.GetComponent<LineRenderer>();
		capsule = gameObject.AddComponent<CapsuleCollider> () as CapsuleCollider;
		capsule.radius = 0.05f;
		capsule.center = Vector3.zero;
		capsule.direction = 2;
		bm = GameObject.FindGameObjectWithTag ("ButtonManager");
		start = bm.GetComponent<ButtonManagerCaso1> ().frames[0].transform;
		target = bm.GetComponent<ButtonManagerCaso1>().frames[1].transform;

		int indiceStart = bm.GetComponent<ButtonManagerCaso1> ().frames [0].GetComponent<Frame>().indice - 1;
		int indiceTarget = bm.GetComponent<ButtonManagerCaso1> ().frames[1].GetComponent<Frame>().indice - 1;
		indiceFinal = (DetermineMenor(indiceStart,indiceTarget))*10 + DetermineMaior(indiceStart,indiceTarget) + 1;

		ShowText ();

		if (!GameObject.Find ("ScoreCounter").GetComponent<Score>().existeLinha(indiceFinal)) {
			Destroy (transform.gameObject);
		}

		//PONTOS:
		GameObject.Find ("ScoreCounter").GetComponent<Score>().addScore(indiceFinal);
	}
	
	// Update is called once per frame
	void Update () {

		line.SetPosition (0, start.position);
		line.SetPosition (1, target.position);

		capsule.transform.position = start.position + (target.position - start.position) / 2;
		capsule.transform.LookAt (start.position);
		capsule.height = (target.position - start.position).magnitude;
	}

	void OnMouseDown(){
		ShowText ();
	}

	int DetermineMenor(int a, int b){
		if (a > b) {return b;} 
		else {return a;}
	}

	int DetermineMaior(int a, int b){
		if (a > b) {return a;} 
		else {return b;}
	}

	void ShowText(){
		GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().newTxt (true, indiceFinal,false);
	}
}
