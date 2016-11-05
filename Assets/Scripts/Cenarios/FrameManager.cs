using UnityEngine;
using System.Collections;

public class FrameManager : MonoBehaviour {

	public bool[] frames = new bool[10];
	int[] correct = new int[10];

	void Start(){
		for (int i = 0; i < 9; i++) {
			frames [i] = false;
		}
		correct[0] = 8;
		correct[1] = 4;
		correct[2] = 3;
		correct[3] = 6;
		correct[4] = 2;
		correct[5] = 5;
		correct[6] = 9;
		correct[7] = 0;
		correct[8] = 7;
		correct[9] = 1;
	}

	public void MarkFrame(int i){
		frames [correct[i]] = true;
	}
}
