using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {
	
	public float zoomSpeed = 4f;
	public float tamanhoCamera;

	void Update () {
		ZoomFromInput ();
	}

	void ZoomFromInput(){
		tamanhoCamera = GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize;

		if (Input.GetMouseButton (1) && tamanhoCamera > 2f) {
			GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize -= zoomSpeed * Time.deltaTime;
			GameObject.Find ("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find ("Main Camera").transform.position,new Vector3(Input.mousePosition.x,Input.mousePosition.y,0),zoomSpeed * Time.deltaTime);
		}
		if (!Input.GetMouseButton (1) && tamanhoCamera < 2.95f) {
			GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize += zoomSpeed* 2f * Time.deltaTime;
			GameObject.Find ("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find ("Main Camera").transform.position,new Vector3(0,0,0),zoomSpeed * Time.deltaTime*2f);
		}
		if (tamanhoCamera > 2.95f) {
			GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize = 2.95f;
			GameObject.Find ("Main Camera").transform.position = new Vector3(0,0,0);
		}
	}
}
