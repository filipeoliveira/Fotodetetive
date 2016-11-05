using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonManagerCaso1 : MonoBehaviour {

	public Button yourButton;
	public GameObject Fundo;
	public GameObject cena;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Fundo.GetComponent<SpriteRenderer> ().enabled = !(Fundo.GetComponent<SpriteRenderer> ().enabled);
		int i = -2;
		foreach(Transform t in Fundo.GetComponentsInChildren<Transform>()){
			i++;
			Debug.Log (i);
			if(i != -1){
				if(Fundo.GetComponent<FrameManager>().frames[i]){
					t.gameObject.GetComponent<SpriteRenderer> ().enabled = !(t.gameObject.GetComponent<SpriteRenderer> ().enabled);
				}
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
