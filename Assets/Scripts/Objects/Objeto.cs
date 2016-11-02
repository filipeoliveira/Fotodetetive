using UnityEngine;
using System.Collections;

public class Objeto : MonoBehaviour {

	public int indice;
	public bool countdown = false;
	float timeLeft = 3.0f;

	void Update(){
		if (countdown) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {
				transform.position = Vector3.MoveTowards (transform.position, GameObject.FindGameObjectWithTag ("Investigar").transform.position, 0.3f);
				if (transform.position != GameObject.FindGameObjectWithTag ("Investigar").transform.position) {
					transform.localScale += new Vector3 (-0.02f, -0.02f, 0);
				}
			}
		}
	}
}
