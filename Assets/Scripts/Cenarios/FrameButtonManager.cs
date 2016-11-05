using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FrameButtonManager : MonoBehaviour {

	public Button[] buttons;

	void Start () {
		foreach(Button btn in buttons) 
			btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){

	}
}
