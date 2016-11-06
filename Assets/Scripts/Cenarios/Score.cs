using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addScore(int s){
		score += s;
	}
}
