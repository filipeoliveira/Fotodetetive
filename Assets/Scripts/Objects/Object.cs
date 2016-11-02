using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	public int indice;
	bool countdown = false;
	float timeLeft = 3.0f;

	void Update(){
		if (countdown) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 0) {

			}
		}
	}
}
