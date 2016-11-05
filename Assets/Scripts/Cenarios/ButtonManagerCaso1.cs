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
		Fundo.gameObject.SetActive(!Fundo.gameObject.activeSelf);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
