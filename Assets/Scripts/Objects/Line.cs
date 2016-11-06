using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

	public Transform start;
	public Transform target;
	public GameObject bm;
	public int indice = 2;

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
		GameObject.FindGameObjectWithTag ("TextManager").GetComponent<TextBoxManager> ().newTxt (true, indice);
	}
}
